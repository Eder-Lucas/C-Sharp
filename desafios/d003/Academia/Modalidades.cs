using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Academia
{
    // Classe que gerencia operações relacionadas as modalidades, como salvar e listar informações
    internal class Modalidades
    {
        // Método para salvar as informações de uma modalidade no banco de dados
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
			catch (Exception)
			{
				throw;
			}
        }

        // Método para alterar as informações de uma modalidade existente no banco de dados
        public void Alterar(int idModalidade, string nome, decimal mensalidade, int idProfessor)
		{
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
					UPDATE Modalidade
					SET	NOME_MODALIDADE = @nome,
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
			catch (Exception)
			{
				throw;
            }
		}

        // Método para excluir uma modalidade do banco de dados
        public void Excluir(int idModalidade)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
					DELETE FROM Modalidade
					WHERE ID_MODALIDADE = @idModalidade
				""";

                using SqlCommand cmd = new(sql, conexao);

                cmd.Parameters.Add("@idModalidade", SqlDbType.Int).Value = idModalidade;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Método para listar as modalidades cadastradas no banco de dados
        // Retorna um DataTable com as informações
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
			catch (Exception)
			{
				throw;
			}
		}

		//Método para pesquisar modalidades pelo nome
		public static DataTable PesquisaModalidade(string nome)
		{
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
					SELECT m.*, p.NOME_PROFESSOR
					FROM Modalidade m
					INNER JOIN Professor p ON m.ID_PROFESSOR = p.ID_PROFESSOR
					WHERE m.NOME_MODALIDADE COLLATE Latin1_General_CI_AI LIKE @nome + '%'
					ORDER BY m.ID_MODALIDADE DESC
				""";

				using SqlCommand cmd = new(sql, conexao);

				cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 50).Value = nome;

				DataTable dadosTabela = new();
				dadosTabela.Load(cmd.ExecuteReader());

				return dadosTabela;	
            }
			catch (Exception)
			{
				throw;
			}
		}

        //Método para pesquisar modalidades pelo nome do professor
        public static DataTable PesquisaProfessor(string nome)
		{
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
					SELECT m.*, p.NOME_PROFESSOR
					FROM Modalidade m
					INNER JOIN Professor p ON m.ID_PROFESSOR = p.ID_PROFESSOR
					WHERE p.NOME_PROFESSOR COLLATE Latin1_General_CI_AI LIKE @nome + '%'
					ORDER BY m.ID_MODALIDADE DESC
				""";

				using SqlCommand cmd = new(sql, conexao);

				cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 50).Value = nome;

				DataTable dadosTabela = new();
				dadosTabela.Load(cmd.ExecuteReader());

				return dadosTabela;	
            }
			catch (Exception)
			{
				throw;
			}
		}
    }
}
