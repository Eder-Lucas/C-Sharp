using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academia
{
    internal class Alunos
    {
        public void Salvar(int idAluno, string nome, string endereco, string bairro, string num,
            string cidade, string cep, string cpf, string tel, string sexo, string obs)
        {
            try
            {
                if (idAluno == 0)
                    Inserir(nome, endereco, bairro, num, cidade, cep, cpf, tel, sexo, obs);
                else
                    Atualizar(idAluno, nome, endereco, bairro, num, cidade, cep, cpf, tel, sexo, obs);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Inserir(string nome, string endereco, string bairro, string num, string cidade,
            string cep, string cpf, string tel, string sexo, string obs)
        {
            try
            {
                using SqlConnection conexao = new SqlConnection(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    INSERT INTO Aluno(
                        NOME_ALUNO, ENDERECO_ALUNO, BAIRRO_ALUNO, NUMERO_ALUNO, CIDADE_ALUNO, CEP_ALUNO,
                        CPF_ALUNO, TELEFONE_ALUNO, SEXO, OBSERVACAO)
                    VALUES (
                        @nome, @endereco, @bairro, @num, @cidade, @cep, @cpf, @tel, @sexo, @obs)
                """;

                using SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar).Value = nome;
                cmd.Parameters.Add("@endereco", System.Data.SqlDbType.NVarChar).Value = endereco;
                cmd.Parameters.Add("@bairro", System.Data.SqlDbType.NVarChar).Value = bairro;
                cmd.Parameters.Add("@num", System.Data.SqlDbType.NVarChar).Value = num;
                cmd.Parameters.Add("@cidade", System.Data.SqlDbType.NVarChar).Value = cidade;
                cmd.Parameters.Add("@cep", System.Data.SqlDbType.NVarChar).Value = cep;
                cmd.Parameters.Add("@cpf", System.Data.SqlDbType.NVarChar).Value = cpf;
                cmd.Parameters.Add("@tel", System.Data.SqlDbType.NVarChar).Value = tel;
                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.NVarChar).Value = sexo;
                cmd.Parameters.Add("@obs", System.Data.SqlDbType.NVarChar).Value = obs;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Atualizar(int idAluno, string nome, string endereco, string bairro, string num, 
            string cidade, string cep, string cpf, string tel, string sexo, string obs)
        {
            try
            {
                using SqlConnection conexao = new SqlConnection(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                UPDATE Aluno
                SET NOME_ALUNO = @nome,
                    ENDERECO_ALUNO = @endereco,
                    BAIRRO_ALUNO = @bairro,
                    NUMERO_ALUNO = @num,
                    CIDADE_ALUNO = @cidade,
                    CEP_ALUNO = @cep,
                    CPF_ALUNO = @cpf,
                    TELEFONE_ALUNO = @tel,
                    SEXO = @sexo,
                    OBSERVACAO = @obs
                WHERE ID_ALUNO = @idAluno
                """;

                using SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar).Value = nome;
                cmd.Parameters.Add("@endereco", System.Data.SqlDbType.NVarChar).Value = endereco;
                cmd.Parameters.Add("@bairro", System.Data.SqlDbType.NVarChar).Value = bairro;
                cmd.Parameters.Add("@num", System.Data.SqlDbType.NVarChar).Value = num;
                cmd.Parameters.Add("@cidade", System.Data.SqlDbType.NVarChar).Value = cidade;
                cmd.Parameters.Add("@cep", System.Data.SqlDbType.NVarChar).Value = cep;
                cmd.Parameters.Add("@cpf", System.Data.SqlDbType.NVarChar).Value = cpf;
                cmd.Parameters.Add("@tel", System.Data.SqlDbType.NVarChar).Value = tel;
                cmd.Parameters.Add("@sexo", System.Data.SqlDbType.NVarChar).Value = sexo;
                cmd.Parameters.Add("@obs", System.Data.SqlDbType.NVarChar).Value = obs;
                cmd.Parameters.Add("@idAluno", System.Data.SqlDbType.Int).Value = idAluno;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir( int idAluno)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    DELETE FROM Aluno
                    WHERE ID_ALUNO = @idAluno
                """;

                using SqlCommand cmd = new(sql, conexao);

                cmd.Parameters.Add("@idAluno", System.Data.SqlDbType.Int).Value = idAluno;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
