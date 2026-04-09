using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Academia
{
    internal class MatriculaService
    {
        public void SalvarTudo(int idAluno, int idTurma, DateTime venc, bool situacao, bool pago)
        {
            SqlTransaction? transacao = null;

            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                transacao = conexao.BeginTransaction();

                string sqlMatricula = """
                    INSERT INTO Matricula (ID_ALUNO, ID_TURMA, VENCIMENTO, SITUACAO)
                    VALUES (@idAluno, @idTurma, @venc, @situacao);
                    SELECT SCOPE_IDENTITY();
                """;

                using SqlCommand cmdMatricula = new(sqlMatricula, conexao, transacao);
                cmdMatricula.Parameters.Add("@idAluno", SqlDbType.Int).Value = idAluno;
                cmdMatricula.Parameters.Add("@idTurma", SqlDbType.Int).Value = idTurma;
                cmdMatricula.Parameters.Add("@venc", SqlDbType.Date).Value = venc;
                cmdMatricula.Parameters.Add("@situacao", SqlDbType.Bit).Value = situacao;

                int idMatricula = Convert.ToInt32((decimal)cmdMatricula.ExecuteScalar());

                string sqlMensalidade = """
                    INSERT INTO Mensalidade (ID_MATRICULA, DATA_VENCIMENTO, SITUACAO)
                    VALUES (@idMatricula, @venc, @pago);
                """;

                using SqlCommand cmdMensalidade = new(sqlMensalidade, conexao, transacao);
                cmdMensalidade.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
                cmdMensalidade.Parameters.Add("@venc", SqlDbType.Date).Value = venc;
                cmdMensalidade.Parameters.Add("@pago", SqlDbType.Bit).Value = pago;

                cmdMensalidade.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception)
            {
                if (transacao?.Connection != null)
                    transacao.Rollback();
                throw;
            }
        }

            public void AlterarTudo(int idMatricula, int idAluno, int idTurma, DateTime venc, bool situacao, int pago)
        {
            SqlTransaction? transacao = null;

            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                transacao = conexao.BeginTransaction();

                string sqlMatricula = """
                    UPDATE Matricula
                    SET ID_ALUNO = @idAluno,
                        ID_TURMA = @idTurma,
                        VENCIMENTO = @venc,
                        SITUACAO = @situacao
                    WHERE ID_MATRICULA = @idMatricula
                """;

                using SqlCommand cmdMatricula = new(sqlMatricula, conexao, transacao);
                cmdMatricula.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
                cmdMatricula.Parameters.Add("@idAluno", SqlDbType.Int).Value = idAluno;
                cmdMatricula.Parameters.Add("@idTurma", SqlDbType.Int).Value = idTurma;
                cmdMatricula.Parameters.Add("@venc", SqlDbType.Date).Value = venc;
                cmdMatricula.Parameters.Add("@situacao", SqlDbType.Bit).Value = situacao;

                cmdMatricula.ExecuteNonQuery();

                // Atualizar mensalidades com segurança
                if (situacao == false)
                {
                    string cancelarMensalidadesSql = """
                        UPDATE Mensalidade
                        SET SITUACAO = 2
                        WHERE ID_MATRICULA = @idMatricula
                          AND SITUACAO = 0
                    """;

                    using SqlCommand cmdCancelar = new(cancelarMensalidadesSql, conexao, transacao);
                    cmdCancelar.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
                    cmdCancelar.ExecuteNonQuery();
                }
                else
                {
                    string ajustarMensalidadesSql = """
                        UPDATE Mensalidade
                        SET DATA_VENCIMENTO = @venc,
                            SITUACAO = @pago
                        WHERE ID_MATRICULA = @idMatricula
                    """;

                    using SqlCommand cmdAjustar = new(ajustarMensalidadesSql, conexao, transacao);
                    cmdAjustar.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
                    cmdAjustar.Parameters.Add("@venc", SqlDbType.Date).Value = venc;
                    cmdAjustar.Parameters.Add("@pago", SqlDbType.Bit).Value = pago;

                    cmdAjustar.ExecuteNonQuery();
                }

                transacao.Commit();
            }
            catch (Exception)
            {
                if (transacao?.Connection != null)
                    transacao.Rollback();
                throw;
            }
        }
    }
}
