using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Academia
{
    internal class Mensalidades
    {
        public void Salvar(int idMatricula, DateTime venc, bool situacao)
        {
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
					INSERT INTO Mensalidade (ID_MATRICULA, DATA_VENCIMENTO, SITUACAO)
					VALUES (@idMatricula, @vencimento, @situacao)
				""";

                using SqlCommand cmd = new(sql, conexao);

				cmd.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
				cmd.Parameters.Add("@vencimento", SqlDbType.Date).Value = venc;
				cmd.Parameters.Add("@situacao", SqlDbType.Bit).Value = situacao;

				cmd.ExecuteNonQuery();

            }
			catch (Exception)
			{
				throw;
			}
        }

		public void Pagar(int idMensalidade, DateTime dataPagamento, bool situacao)
		{
            SqlTransaction? transacao = null;

            try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

                transacao = conexao.BeginTransaction();

                // Salvando a mensalidade como paga
                string pagamentoSql = """
					UPDATE Mensalidade
					SET DATA_PAGAMENTO = @dataPagamento, SITUACAO = @situacao
					WHERE ID_MENSALIDADE = @idMensalidade
				""";

                using SqlCommand cmdPagamento = new(pagamentoSql, conexao, transacao);
                cmdPagamento.Parameters.Add("@idMensalidade", SqlDbType.Int).Value = idMensalidade;
                cmdPagamento.Parameters.Add("@dataPagamento", SqlDbType.Date).Value = dataPagamento;
                cmdPagamento.Parameters.Add("@situacao", SqlDbType.Bit).Value = situacao;

                cmdPagamento.ExecuteNonQuery();

                // Coletando os dados para gerar a próxima mensalidade
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

                // Gerando a próxima mensalidade
                //DateTime proximoVencimento = vencimentoAtual.AddMonths(1);

                /* Insere uma nova mensalidade e atualiza o vencimento da matrícula
                string proximaMensalidadeSql = """
					INSERT INTO Mensalidade (ID_MATRICULA, DATA_VENCIMENTO, SITUACAO)
					VALUES (@idMatricula, @proximoVencimento, 0);

					UPDATE Matricula
					SET VENCIMENTO = @proximoVencimento
					WHERE ID_MATRICULA = @idMatricula;
				""";

				using SqlCommand cmdProxima = new(proximaMensalidadeSql, conexao, transacao);
				cmdProxima.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
				cmdProxima.Parameters.Add("@proximoVencimento", SqlDbType.Date).Value = proximoVencimento;

				cmdProxima.ExecuteNonQuery();*/

                transacao.Commit();
            }
			catch (Exception)
			{
                if (transacao?.Connection != null)
                    transacao.Rollback();
                throw;
			}
		}

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
    }
}
