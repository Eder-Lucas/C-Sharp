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
					SELECT men.*, md.NOME_MODALIDADE, md.MENSALIDADE, m.ID_ALUNO
					FROM Mensalidade men
					INNER JOIN Matricula m
						ON m.ID_MATRICULA = men.ID_MATRICULA
					INNER JOIN TURMA t
						ON t.ID_TURMA = m.ID_TURMA
					INNER JOIN MODALIDADE md
						ON md.ID_MODALIDADE = t.ID_MODALIDADE
					WHERE m.ID_ALUNO = @idAluno
					ORDER BY men.DATA_VENCIMENTO DESC
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

		public DataTable Filtrar(int idMatricula, bool situacao)
		{
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
					SELECT * FROM Mensalidade
					WHERE ID_MATRICULA = @idMatricula 
					AND SITUACAO = @situacao
				""";

				using SqlCommand cmd = new(sql, conexao);
				cmd.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
				cmd.Parameters.Add("@situacao", SqlDbType.Bit).Value = situacao;

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
    }
}
