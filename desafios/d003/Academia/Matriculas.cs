using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Academia
{
    internal class Matriculas
    {
        public void Salvar(int idMatricula, int idAluno, int idTurma, DateTime venc, bool situacao)
        {
            try
            {
                ValidaRegras(idAluno, idTurma, idMatricula, situacao, venc);

                if (idMatricula == 0)
                    Inserir(idAluno, idTurma, venc, situacao);
                else
                    Atualizar(idMatricula, idAluno, idTurma, venc, situacao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Inserir(int idAluno, int idTurma, DateTime venc, bool situacao)
        {
            try
            {
                using SqlConnection conexao = new SqlConnection(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    INSERT INTO Matricula (ID_ALUNO, ID_TURMA, VENCIMENTO, SITUACAO)
                    VALUES (@idAluno, @idTurma, @venc, @situacao)
                """;

                using SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.Add("@idAluno", System.Data.SqlDbType.Int).Value = idAluno;
                cmd.Parameters.Add("@idTurma", System.Data.SqlDbType.Int).Value = idTurma;
                cmd.Parameters.Add("@venc", System.Data.SqlDbType.Date).Value = venc;
                cmd.Parameters.Add("@situacao", System.Data.SqlDbType.Bit).Value = situacao;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Atualizar(int idMatricula, int idAluno, int idTurma, DateTime venc, bool situacao)
        {
            try
            {
                using SqlConnection conexao = new SqlConnection(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    UPDATE Matricula
                    SET ID_ALUNO = @idAluno,
                        ID_TURMA = @idTurma,
                        VENCIMENTO = @venc,
                        SITUACAO = @situacao
                    WHERE ID_MATRICULA = @idMatricula
                """;

                using SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.Add("@idAluno", System.Data.SqlDbType.Int).Value = idAluno;
                cmd.Parameters.Add("@idTurma", System.Data.SqlDbType.Int).Value = idTurma;
                cmd.Parameters.Add("@venc", System.Data.SqlDbType.Date).Value = venc;
                cmd.Parameters.Add("@situacao", System.Data.SqlDbType.Bit).Value = situacao;
                cmd.Parameters.Add("@idMatricula", System.Data.SqlDbType.Int).Value = idMatricula;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(int idMatricula)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    DELETE FROM Matricula
                    WHERE ID_MATRICULA = @idMatricula
                """;

                using SqlCommand cmd = new(sql, conexao);

                cmd.Parameters.Add("@idMatricula", System.Data.SqlDbType.Int).Value = idMatricula;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarTurmas()
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT * FROM Turma
                    ORDER BY ID_TURMA DESC
                """;

                using SqlCommand cmd = new(sql, conexao);

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

        public DataTable RetornarMatriculas(int idAluno)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT * FROM Matricula
                    WHERE ID_ALUNO = @idAluno
                    ORDER BY ID_MATRICULA DESC
                """;

                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@idAluno", System.Data.SqlDbType.Int).Value = idAluno;

                DataTable tabela = new();

                using SqlDataReader leitor = cmd.ExecuteReader();
                tabela.Load(leitor);

                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable RetornarTurmasMatriculadas(int idAluno)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT m.*, t.NUMERO_TURMA, md.NOME_MODALIDADE, md.MENSALIDADE
                    FROM Matricula m
                    INNER JOIN Turma t ON m.ID_TURMA = t.ID_TURMA
                    INNER JOIN Aluno a ON m.ID_ALUNO = a.ID_ALUNO
                    INNER JOIN Modalidade md ON t.ID_MODALIDADE = md.ID_MODALIDADE
                    WHERE m.ID_ALUNO = @idAluno
                    ORDER BY m.ID_MATRICULA DESC
                """;

                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@idAluno", System.Data.SqlDbType.Int).Value = idAluno;

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

        public bool ExisteMatriculaAtiva(int idAluno, int idTurma)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT 1
                    FROM Matricula
                    WHERE ID_ALUNO = @idAluno
                    AND ID_TURMA = @idTurma
                    AND SITUACAO = 1
                """;

                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@idAluno", System.Data.SqlDbType.Int).Value = idAluno;
                cmd.Parameters.Add("@idTurma", System.Data.SqlDbType.Int).Value = idTurma;

                using SqlDataReader leitor = cmd.ExecuteReader();
                return leitor.HasRows;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ExisteMatriculaInativa(int idAluno, int idTurma)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT 1
                    FROM Matricula
                    WHERE ID_ALUNO = @idAluno
                    AND ID_TURMA = @idTurma
                    AND SITUACAO = 0
                """;

                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@idAluno", System.Data.SqlDbType.Int).Value = idAluno;
                cmd.Parameters.Add("@idTurma", System.Data.SqlDbType.Int).Value = idTurma;

                using SqlDataReader leitor = cmd.ExecuteReader();
                return leitor.HasRows;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int VagasDisponiveis(int idTurma)
        {
            using SqlConnection conexao = new(Conexao.StringConexao);
            conexao.Open();

            string sql = """
                SELECT 
                    t.MAXIMO_ALUNOS - COUNT(m.ID_MATRICULA)
                FROM Turma t
                LEFT JOIN Matricula m 
                    ON m.ID_TURMA = t.ID_TURMA 
                    AND m.SITUACAO = 1
                WHERE t.ID_TURMA = @idTurma
                GROUP BY t.MAXIMO_ALUNOS
            """;

            using SqlCommand cmd = new(sql, conexao);
            cmd.Parameters.Add("@idTurma", SqlDbType.Int).Value = idTurma;

            return (int)cmd.ExecuteScalar();
        }

        private void ValidaRegras(int idAluno, int idTurma, int idMatricula, bool situacao, DateTime venc)
        {
            if (VagasDisponiveis(idTurma) <= 0 && idMatricula == 0)
                throw new Exception("Não há vagas disponíveis para esta turma.");

            if (idMatricula == 0 && !situacao)
                throw new Exception("Não é possível criar uma matrícula inativa. Por favor, ative a matrícula após criá-la.");
            
            if (venc.Date <= DateTime.Today)
                throw new Exception("A data de vencimento não pode ser anterior ou igual a data atual.");         
        }
    }
}
