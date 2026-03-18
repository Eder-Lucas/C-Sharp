using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Academia
{
    // Classe que gerencia operações relacionadas as turmas, como salvar e listar informações
    internal class Turmas
    {
        // Método para salvar as informações de uma turma no banco de dados
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
            catch (Exception)
            {
                throw;
            }
        }

        // Método para alterar as informações de uma turma existente no banco de dados
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

        // Método para excluir uma turma do banco de dados
        public void Excluir(int idTurma)
        {
            SqlTransaction? transacao = null;

            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                transacao = conexao.BeginTransaction();

                string sql = """
                    DELETE FROM Mensalidade
                    WHERE ID_MATRICULA IN (
                        SELECT ID_MATRICULA
                        FROM Matricula
                        WHERE ID_TURMA = @idTurma
                    );

                    DELETE FROM Matricula
                    WHERE ID_TURMA = @idTurma;

                    DELETE FROM Horario
                    WHERE ID_TURMA = @idTurma;

                    DELETE FROM Turma
                    WHERE ID_TURMA = @idTurma
                """;

                using SqlCommand cmd = new(sql, conexao, transacao);

                cmd.Parameters.Add("@idTurma", SqlDbType.Int).Value = idTurma;

                cmd.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception)
            {
                transacao?.Rollback();
                throw;
            }
        }

        // Método para listar as turmas cadastradas no banco de dados
        // Retorna um DataTable com as informações
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
            catch (Exception)
            {
                throw;
            }
        }
    }
}
