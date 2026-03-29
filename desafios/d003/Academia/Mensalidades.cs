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
					INSERT INTO Mensalidade (ID_MATRICULA, VENCIMENTO, SITUACAO)
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

		public DataTable Listar(int idMatricula)
		{
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
					SELECT * FROM Mensalidade
					WHERE ID_MATRICULA = @idMatricula
					ORDER BY VENCIMENTO DESC
				""";

				using SqlCommand cmd = new(sql, conexao);
				cmd.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;

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
