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
					AND men.DATA_VENCIMENTO < CAST(GETDATE() AS DATE)
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
