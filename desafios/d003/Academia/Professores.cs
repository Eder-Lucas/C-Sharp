using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Academia
{
    // Classe que gerencia operações relacionadas aos professores, como salvar e listar informações
    internal class Professores
    {
        // Método para salvar as informações de um professor no banco de dados
        // Recebe todos os dados pelo parâmetro
        public void Salvar(string nome, string endereco, string numero, string bairro, string cidade,
            string cep, string cpf, decimal salario, string telefone, string observacao)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    INSERT INTO Professor (
                    NOME_PROFESSOR, ENDERECO_PROFESSOR, NUMERO_PROFESSOR, BAIRRO_PROFESSOR,
                    CIDADE_PROFESSOR, CEP_PROFESSOR, CPF_PROFESSOR, SALARIO, TELEFONE_PROFESSOR, OBSERVACAO
                    )  
                    VALUES (@nome, @endereco, @numero, @bairro, @cidade, @cep, @cpf, @salario, @telefone, @observacao)
                """;

                using SqlCommand comandoSql = new();

                comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                comandoSql.Parameters.Add(new SqlParameter("@numero", numero));
                comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
                comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
                comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
                comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                comandoSql.Parameters.Add(new SqlParameter("@salario", salario));
                comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                comandoSql.Parameters.Add(new SqlParameter("@observacao", observacao));

                comandoSql.CommandText = sql;
                comandoSql.Connection = conexao;
                comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Alterar(int idProfessor, string nome, string endereco, string numero, string bairro,
            string cidade, string cep, string cpf, decimal salario, string telefone, string observacao)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = @"
                    UPDATE Professor
                    SET NOME_PROFESSOR = @nome,
                        ENDERECO_PROFESSOR = @endereco,
                        NUMERO_PROFESSOR = @numero,
                        BAIRRO_PROFESSOR = @bairro,
                        CIDADE_PROFESSOR = @cidade,
                        CEP_PROFESSOR = @cep,
                        CPF_PROFESSOR = @cpf,
                        SALARIO = @salario,
                        TELEFONE_PROFESSOR = @telefone,
                        OBSERVACAO = @observacao
                    WHERE ID_PROFESSOR = @idProfessor
                ";

                using SqlCommand comandoSql = new();

                comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
                comandoSql.Parameters.Add(new SqlParameter("@numero", numero));
                comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
                comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
                comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
                comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
                comandoSql.Parameters.Add(new SqlParameter("@salario", salario));
                comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
                comandoSql.Parameters.Add(new SqlParameter("@observacao", observacao));
                comandoSql.Parameters.Add(new SqlParameter("@idProfessor", idProfessor));

                comandoSql.CommandText = sql;
                comandoSql.Connection = conexao;
                comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public void Excluir(int idProfessor)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = "DELETE FROM Professor WHERE (ID_PROFESSOR = @idProfessor)";

                using SqlCommand comandoSql = new(sql, conexao);

                comandoSql.Parameters.Add(new SqlParameter("@idProfessor", idProfessor));

                comandoSql.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Método que lista as informações dos professores e retorna os dados em um DataTable
        public DataTable Listar()
        {
            try
            {
                DataTable dadosTabela = new();

                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = "SELECT * FROM Professor ORDER BY ID_PROFESSOR DESC";

                using SqlCommand comandoSql = new(sql, conexao);

                using SqlDataReader leitor = comandoSql.ExecuteReader();              
                dadosTabela.Load(leitor);

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        // Método que pesquisa os professores pelo nome e retorna os dados em um DataTable
        public DataTable PesquisaNome(string nome)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = @"
                    SELECT * FROM Professor
                    WHERE (NOME_PROFESSOR LIKE @nome + '%')
                    ORDER BY ID_PROFESSOR DESC";

                using SqlCommand comandoSql = new(sql, conexao);

                comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

                DataTable dadosTabela = new();
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        // Método que pesquisa os professores pelo CPF e retorna os dados em um DataTable
        public DataTable PesquisaCpf(string cpf)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = @"
                    SELECT * FROM Professor
                    WHERE (CPF_PROFESSOR LIKE @cpf + '%')
                    ORDER BY ID_PROFESSOR DESC";

                using SqlCommand comandoSql = new(sql, conexao);

                comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));

                DataTable dadosTabela = new();
                dadosTabela.Load(comandoSql.ExecuteReader());

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
