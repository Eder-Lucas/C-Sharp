using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Academia
{
    internal class Modalidades
    {
        public void Salvar(string nome, decimal mensalidade, int idProfessor)
        {
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
					INSERT INTO Modalidade (NOME_MODALIDADE, MENSALIDADE, ID_PROFESSOR)
					VALUES (@nome, @mensalidade, @idProfessor)
				""";

				using SqlCommand cmd = new(sql, conexao);

				cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 50).Value = nome;

				var valor = cmd.Parameters.Add("@mensalidade", SqlDbType.Decimal);
				valor.Precision = 6;
				valor.Scale = 2;
				valor.Value = mensalidade;
				
				cmd.Parameters.Add("@idProfessor", SqlDbType.Int).Value = idProfessor;

				cmd.ExecuteNonQuery();
            }
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
        }

		public void Alterar(int idModalidade, string nome, decimal mensalidade, int idProfessor)
		{
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
					UPADATE Modalidade
					SET ID_MODALIDADE = @idModalidade,
						NOME_MODALIDADE = @nome,
						MENSALIDADE = @mensalidade,
						ID_PROFESSOR = @idProfessor
					WHERE ID_MODALIDADE = @idModalidade
				""";

				using SqlCommand cmd = new(sql, conexao);

				cmd.Parameters.Add("@idModalidade", SqlDbType.Int).Value = idModalidade;
				cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 50).Value = nome;

                var valor = cmd.Parameters.Add("@mensalidade", SqlDbType.Decimal);
                valor.Precision = 6;
                valor.Scale = 2;
                valor.Value = mensalidade;

				cmd.Parameters.Add("@idProfessor", SqlDbType.Int).Value = idProfessor;

				cmd.ExecuteNonQuery();
            }
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
            }
		}

		public DataTable Listar()
		{
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
					SELECT m.*, p.NOME_PROFESSOR
					FROM Modalidade m
					INNER JOIN Professor p ON m.ID_PROFESSOR = p.ID_PROFESSOR
					ORDER BY m.ID_MODALIDADE DESC
				""";

				using SqlCommand cmd = new(sql, conexao);

				DataTable tabela = new();
				tabela.Load(cmd.ExecuteReader());

				return tabela; 
            }
			catch (Exception ex)
			{

				throw new Exception(ex.Message, ex);
			}
		}
    }
}
