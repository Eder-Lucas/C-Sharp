using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Academia
{
    internal class Turmas
    {
        public void Salvar(int idModalidade, int maxAlunos, int numTurma)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    INSERT INTO Turma (ID_MODALIDADE, MAXIMO_ALUNOS, NUMERO_TURMA)
                    VALUES (@idModalidade, @maxAlunos, @numTurma)
                """;

                using SqlCommand cmd = new(sql, conexao);

                cmd.Parameters.Add("@idModalidade", SqlDbType.Int).Value = idModalidade;
                cmd.Parameters.Add("@maxAlunos", SqlDbType.Int).Value = maxAlunos;
                cmd.Parameters.Add("@numTurma", SqlDbType.Int).Value = numTurma;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Alterar(int idTurma, int idModalidade, int maxAlunos, int numTurma)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    UPDATE Turma
                    SET ID_MODALIDADE = @idModalidade,
                        MAXIMO_ALUNOS = @maxAlunos,
                        NUMERO_TURMA = @numTurma
                    WHERE ID_TURMA = @idTurma
                """;

                using SqlCommand cmd = new(sql, conexao);

                cmd.Parameters.Add("@idTurma", SqlDbType.Int).Value = idTurma;
                cmd.Parameters.Add("@idModalidade", SqlDbType.Int).Value = idModalidade;
                cmd.Parameters.Add("@maxAlunos", SqlDbType.Int).Value = maxAlunos;
                cmd.Parameters.Add("@numTurma", SqlDbType.Int).Value = numTurma;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(int idTurma)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    DELETE FROM Turma
                    WHERE ID_TURMA = @idTurma
                """;

                using SqlCommand cmd = new(sql, conexao);

                cmd.Parameters.Add("@idTurma", SqlDbType.Int).Value = idTurma;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Listar()
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT t.*, m.NOME_MODALIDADE
                    FROM Turma t
                    INNER JOIN Modalidade m ON t.ID_MODALIDADE = m.ID_MODALIDADE
                    ORDER BY t.ID_TURMA DESC
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
