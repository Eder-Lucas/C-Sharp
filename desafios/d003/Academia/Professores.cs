using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Academia
{
    internal class Professores
    {
        public void Salvar(string nome, string endereco, string numero, string bairro, string cidade,
            string cep, string cpf, decimal salario, string telefone, string observacao)
        {
            try
            {
                SqlCommand comandoSql = new();
                StringBuilder sql = new();

                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                sql.Append("INSERT INTO Professor (NOME_PROFESSOR, ENDERECO_PROFESSOR, NUMERO_PROFESSOR, BAIRRO_PROFESSOR, ");
                sql.Append("CIDADE_PROFESSOR, CEP_PROFESSOR, CPF_PROFESSOR, SALARIO, TELEFONE_PROFESSOR, OBSERVACAO)");
                sql.Append("VALUES (@nome, @endereco, @numero, @bairro, @cidade, @cep, @cpf, @salario, @telefone, @observacao)");

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

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                comandoSql.ExecuteNonQuery();
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
                DataTable dadosTabela = new();

                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = "SELECT * FROM Professor ORDER BY ID_PROFESSOR DESC";

                SqlCommand comandoSql = new(sql, conexao);

                using SqlDataReader leitor = comandoSql.ExecuteReader();
                
                dadosTabela.Load(leitor);

                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
