using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Academia
{
    internal class Mensalidades
    {
		public DataTable Listar(int idAluno)
		{
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
					SELECT				
						men.*,
						md.NOME_MODALIDADE,
						md.MENSALIDADE,
						m.ID_ALUNO,
						CASE
							WHEN men.SITUACAO = 2 THEN 'CANCELADA'
							WHEN men.SITUACAO = 1 THEN 'PAGO'
							WHEN men.SITUACAO = 0 AND men.DATA_VENCIMENTO < CAST(GETDATE() AS DATE) THEN 'ATRASADA'
							WHEN men.SITUACAO = 0 AND men.DATA_VENCIMENTO >= CAST(GETDATE() AS DATE) THEN 'EM ABERTO'
						END AS STATUS_MENSALIDADE

					FROM Mensalidade men
					INNER JOIN Matricula m
						ON m.ID_MATRICULA = men.ID_MATRICULA
					INNER JOIN TURMA t
						ON t.ID_TURMA = m.ID_TURMA
					INNER JOIN MODALIDADE md
						ON md.ID_MODALIDADE = t.ID_MODALIDADE
					WHERE m.ID_ALUNO = @idAluno
					ORDER BY men.DATA_VENCIMENTO DESC, men.ID_MENSALIDADE DESC
				""";

				using SqlCommand cmd = new(sql, conexao);
				cmd.Parameters.Add("@idAluno", SqlDbType.Int).Value = idAluno;

				DataTable tabela = new();

				using SqlDataReader leitor = cmd.ExecuteReader();
				tabela.Load(leitor);

				return tabela;

            }
			catch (Exception)
			{

				throw;
			}
		}

		public DataTable Filtrar(int idAluno, string filtro)
		{
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
						SELECT
						men.*,
						md.NOME_MODALIDADE,
						md.MENSALIDADE,
						m.ID_ALUNO,
						CASE
							WHEN men.SITUACAO = 2 THEN 'CANCELADA'
							WHEN men.SITUACAO = 1 THEN 'PAGO'
							WHEN men.SITUACAO = 0 AND men.DATA_VENCIMENTO < CAST(GETDATE() AS DATE) THEN 'ATRASADA'
							ELSE 'EM ABERTO'
						END AS STATUS_MENSALIDADE
				
					FROM Mensalidade men
					INNER JOIN Matricula m
						ON m.ID_MATRICULA = men.ID_MATRICULA
					INNER JOIN TURMA t
						ON t.ID_TURMA = m.ID_TURMA
					INNER JOIN MODALIDADE md
						ON md.ID_MODALIDADE = t.ID_MODALIDADE
					WHERE m.ID_ALUNO = @idAluno
					AND(@filtro = 'Todas' OR (men.SITUACAO = 1 AND @filtro = 'Pagas') OR (men.SITUACAO = 0 AND @filtro = 'Pendentes'))
					ORDER BY men.DATA_VENCIMENTO DESC, men.ID_MENSALIDADE DESC
				""";

				using SqlCommand cmd = new(sql, conexao);
				cmd.Parameters.Add("@idAluno", SqlDbType.Int).Value = idAluno;
				cmd.Parameters.Add("@filtro", SqlDbType.VarChar).Value = filtro;

				DataTable tabela = new();

				using SqlDataReader leitor = cmd.ExecuteReader();
				tabela.Load(leitor);

				return tabela;
            }
			catch (Exception)
			{

				throw;
			}
		}

		public decimal TotalAtraso(int idAluno)
		{
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
					SELECT ISNULL(SUM(md.MENSALIDADE), 0)
					FROM Mensalidade men
					INNER JOIN Matricula m
						ON m.ID_MATRICULA = men.ID_MATRICULA
					INNER JOIN TURMA t
						ON t.ID_TURMA = m.ID_TURMA
					INNER JOIN MODALIDADE md
						ON md.ID_MODALIDADE = t.ID_MODALIDADE
					WHERE m.ID_ALUNO = @idAluno
					AND men.SITUACAO = 0				
				""";

				using SqlCommand cmd = new(sql, conexao);
				cmd.Parameters.Add("@idAluno", SqlDbType.Int).Value = idAluno;

                decimal atraso = Convert.ToDecimal(cmd.ExecuteScalar());
				return atraso;
            }
			catch (Exception)
			{

				throw;
			}
		}

        public void Pagar(int idMensalidade, DateTime dataPagamento, bool situacao, bool gerar, int qtdMeses)
        {
            SqlTransaction? transacao = null;

            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                transacao = conexao.BeginTransaction();
				
				// obtem os dados necessarios para o pagamento
				var (idMatricula, vencimentoAtual) = ObterDadosMensalidade(transacao, conexao, idMensalidade);
				var ids = ObterMensalidadesAbertas(transacao, conexao, idMatricula, qtdMeses);
                var proximo = ObterUltimoVencimento(transacao, conexao, idMatricula, vencimentoAtual);
                int faltam = qtdMeses - ids.Count;

                PagaMensalidades(transacao, conexao, ids, dataPagamento);

                if (faltam > 0)
                {
                    
                }

				if (gerar)
				{
					DateTime ultimo = ObterUltimoVencimento(transacao, conexao, idMatricula, vencimentoAtual);
					ultimo = ultimo.AddMonths(1);

					string sql = """
						IF NOT EXISTS (
							SELECT 1 
							FROM Mensalidade
							WHERE ID_MATRICULA = @idMatricula
							AND DATA_VENCIMENTO = @proximo
						)
						BEGIN
							INSERT INTO Mensalidade (ID_MATRICULA, DATA_VENCIMENTO, SITUACAO)
							VALUES (
							@idMatricula,
							DATEFROMPARTS(
								YEAR(@proximo),
								MONTH(@proximo),
								CASE 
									WHEN DAY(@vencimentoBase) > DAY(EOMONTH(@proximo)) 
										THEN DAY(EOMONTH(@proximo))
									ELSE DAY(@vencimentoBase)
								END
								),
								0
							);
						END
					""";

					using SqlCommand cmd = new(sql, conexao, transacao);
					cmd.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
					cmd.Parameters.Add("@proximo", SqlDbType.Date).Value= ultimo;
					cmd.Parameters.Add("@vencimentoBase", SqlDbType.Date).Value = vencimentoAtual;

					cmd.ExecuteNonQuery();

				}

                transacao.Commit();
            }
            catch (Exception)
            {
                if (transacao?.Connection != null)
                    transacao.Rollback();
                throw;
            }
        }

		private (int idMatricula, DateTime vencimentoAtual) ObterDadosMensalidade(SqlTransaction transacao, SqlConnection conexao, int idMensalidade)
		{
            // Coleta os dados
            string buscarDadosSql = """
					SELECT m.ID_MATRICULA, m.DATA_VENCIMENTO
					FROM Mensalidade m
					WHERE m.ID_MENSALIDADE = @idMensalidade
				""";

            using SqlCommand cmdBuscar = new(buscarDadosSql, conexao, transacao);
            cmdBuscar.Parameters.Add("@idMensalidade", SqlDbType.Int).Value = idMensalidade;
            using SqlDataReader leitor = cmdBuscar.ExecuteReader();

            if (!leitor.Read())
                throw new Exception("Mensalidade não encontrada.");

            int idMatricula = leitor.GetInt32(0);
            DateTime vencimentoAtual = leitor.GetDateTime(1);

            leitor.Close();

			return (idMatricula, vencimentoAtual);
        }

		private List<int> ObterMensalidadesAbertas(SqlTransaction transacao, SqlConnection conexao, int idMatricula, int qtdMeses)
		{
            List<int> ids = [];

            // seleciona todas nao pagas
            string proximaMensalidadeSql = """
					SELECT TOP (@qtd)
						ID_MENSALIDADE
					FROM Mensalidade
					WHERE ID_MATRICULA = @idMatricula
						AND SITUACAO = 0
					ORDER BY DATA_VENCIMENTO;
				""";

            using SqlCommand cmdProxima = new(proximaMensalidadeSql, conexao, transacao);
            cmdProxima.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
            cmdProxima.Parameters.Add("@qtd", SqlDbType.Int).Value = qtdMeses;

            using SqlDataReader ler = cmdProxima.ExecuteReader();

            while (ler.Read())
                ids.Add(ler.GetInt32(0));

            ler.Close();

			return ids;
        }

		private DateTime ObterUltimoVencimento(SqlTransaction transacao, SqlConnection conexao, int idMatricula, DateTime vencimentoAtual)
		{
            // pega última data
            string sqlUltima = """
						SELECT MAX(DATA_VENCIMENTO)
						FROM Mensalidade
						WHERE ID_MATRICULA = @idMatricula
					""";

            using SqlCommand cmdUltima = new(sqlUltima, conexao, transacao);
            cmdUltima.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;

            object resultado = cmdUltima.ExecuteScalar();

            DateTime ultimoVencimento = resultado == DBNull.Value
                ? vencimentoAtual
                : (DateTime)resultado;

            DateTime proximo = ultimoVencimento;

            return proximo;
        }

		private void PagaMensalidades(SqlTransaction transacao, SqlConnection conexao, List<int> ids, DateTime dataPagamento)
		{
            // paga todas em ordem
            foreach (int id in ids)
            {
                string updateSql = """
						UPDATE Mensalidade
						SET DATA_PAGAMENTO = @dataPagamento,
							SITUACAO = 1
						WHERE ID_MENSALIDADE = @id
					""";

                using SqlCommand cmdUpdate = new(updateSql, conexao, transacao);
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdUpdate.Parameters.Add("@dataPagamento", SqlDbType.Date).Value = dataPagamento;

                cmdUpdate.ExecuteNonQuery();
            }
        }

		private void GerarMensalidadesFaltantes(SqlTransaction transacao, SqlConnection conexao, int idMatricula, DateTime proximo, DateTime vencimentoBase, int faltam)
		{
            for (int i = 0; i < faltam; i++)
            {

                proximo = proximo.AddMonths(1);

                string variosMesesSql = """
						INSERT INTO Mensalidade (ID_MATRICULA, DATA_VENCIMENTO, DATA_PAGAMENTO, SITUACAO)
						VALUES (
						@idMatricula,
						DATEFROMPARTS(
						    YEAR(@data),
						    MONTH(@data),
						    CASE 
						        WHEN DAY(@vencimentoBase) > DAY(EOMONTH(@data)) 
						            THEN DAY(EOMONTH(@data))
						        ELSE DAY(@vencimentoBase)
						    END
							),
							@dataPagamento,
							1
						);
					""";

                using SqlCommand cmdVarios = new(variosMesesSql, conexao, transacao);
                cmdVarios.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
                cmdVarios.Parameters.Add("@dataPagamento", SqlDbType.Date).Value = dataPagamento;
                cmdVarios.Parameters.Add("@data", SqlDbType.Date).Value = proximo;
                cmdVarios.Parameters.Add("@vencimentoBase", SqlDbType.Date).Value = vencimentoAtual;
                cmdVarios.ExecuteNonQuery();
            }
        }
    }
}
