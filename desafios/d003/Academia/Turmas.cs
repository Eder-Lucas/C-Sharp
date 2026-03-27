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
        public void Salvar(int idTurma, int idModalidade, int maxAlunos, int numTurma)
        {
            try
            {
                ValidaRegras(idTurma, idModalidade, maxAlunos, numTurma);

                if (idTurma == 0)
                    Inserir(idModalidade, maxAlunos, numTurma);
                else
                    Atualizar(idTurma, idModalidade, maxAlunos, numTurma);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        // Método para salvar as informações de uma turma no banco de dados
        public void Inserir(int idModalidade, int maxAlunos, int numTurma)
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
        public void Atualizar(int idTurma, int idModalidade, int maxAlunos, int numTurma)
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
                    SELECT 
                        t.ID_TURMA,
                        t.MAXIMO_ALUNOS,
                        t.NUMERO_TURMA,
                        md.NOME_MODALIDADE,
                        (t.MAXIMO_ALUNOS - COUNT(m.ID_MATRICULA)) AS VAGAS
                    
                    FROM Turma t
                    LEFT JOIN Matricula m ON m.ID_TURMA = t.ID_TURMA
                    INNER JOIN Modalidade md ON t.ID_MODALIDADE = md.ID_MODALIDADE
                    
                    GROUP BY
                        t.ID_TURMA,
                        t.NUMERO_TURMA,
                        t.MAXIMO_ALUNOS,
                        md.NOME_MODALIDADE
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

        public int QuantidadeMatriculas(int idTurma)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT COUNT(*)
                    FROM Matricula
                    WHERE ID_TURMA = @idTurma
                """;

                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@idTurma", System.Data.SqlDbType.Int).Value = idTurma;

                return (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool ValidaRegras(int idTurma, int idModalidade, int maxAlunos, int numTurma)
        {
            if (maxAlunos <= 0)
                throw new Exception("O máximo de alunos deve ser maior que zero.");

            if (idTurma != 0)
            {
                int vagas = maxAlunos - QuantidadeMatriculas(idTurma);

                if (vagas <= 0)
                    throw new Exception("O máximo de alunos não pode ser menor que a quantidade já matriculada.");
            }

            return true;
        }
    }
}
