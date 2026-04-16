using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Academia
{
    internal class MatriculaService
    {
        public void GerarMensalidade()
        {
            SqlTransaction? transacao = null;

            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                transacao = conexao.BeginTransaction();

                string geraMensalidadeSql = """
                    WITH UltimaMensalidade AS (
                        SELECT 
                            m.ID_MATRICULA,
                            m.VENCIMENTO,
                            ISNULL(MAX(ms.DATA_VENCIMENTO), m.VENCIMENTO) AS ULTIMA_DATA
                        FROM Matricula m
                        LEFT JOIN Mensalidade ms ON ms.ID_MATRICULA = m.ID_MATRICULA
                        WHERE m.SITUACAO = 1
                        GROUP BY m.ID_MATRICULA, m.VENCIMENTO
                    ),
                    Meses AS (
                        SELECT 
                            ID_MATRICULA,
                            VENCIMENTO,
                            DATEADD(MONTH, 1, ULTIMA_DATA) AS DATA
                        FROM UltimaMensalidade
                        WHERE DATEADD(MONTH, 1, ULTIMA_DATA) <= EOMONTH(GETDATE())

                        UNION ALL

                        SELECT 
                            ID_MATRICULA,
                            VENCIMENTO,
                            DATEADD(MONTH, 1, DATA)
                        FROM Meses
                        WHERE 
                            DATEADD(MONTH, 1, DATA) <= EOMONTH(GETDATE())
                    )
                    INSERT INTO Mensalidade (ID_MATRICULA, DATA_VENCIMENTO, SITUACAO)
                    SELECT 
                        ID_MATRICULA,
                        DATEFROMPARTS(
                            YEAR(DATA),
                            MONTH(DATA),
                            CASE 
                                WHEN DAY(VENCIMENTO) > DAY(EOMONTH(DATA)) 
                                    THEN DAY(EOMONTH(DATA))
                                ELSE DAY(VENCIMENTO)
                            END
                        ),
                        0
                    FROM Meses
                    WHERE NOT EXISTS (
                        SELECT 1 FROM Mensalidade ms
                        WHERE ms.ID_MATRICULA = Meses.ID_MATRICULA
                        AND YEAR(ms.DATA_VENCIMENTO) = YEAR(Meses.DATA)
                        AND MONTH(ms.DATA_VENCIMENTO) = MONTH(Meses.DATA)
                    )
                    OPTION (MAXRECURSION 1000);
                """;

                using SqlCommand cmdGerar = new(geraMensalidadeSql, conexao, transacao);
                cmdGerar.ExecuteNonQuery();

                string updateMatriculasql = """
                    UPDATE m
                    SET VENCIMENTO = DATEFROMPARTS(
                        YEAR(ms.MAX_DATA),
                        MONTH(ms.MAX_DATA),
                        CASE 
                            WHEN DAY(m.VENCIMENTO) > DAY(EOMONTH(ms.MAX_DATA)) 
                                THEN DAY(EOMONTH(ms.MAX_DATA))
                            ELSE DAY(m.VENCIMENTO)
                        END
                    )
                    FROM Matricula m
                    JOIN (
                        SELECT 
                            ID_MATRICULA, 
                            MAX(DATA_VENCIMENTO) AS MAX_DATA
                        FROM Mensalidade
                        WHERE SITUACAO <> 2
                        GROUP BY ID_MATRICULA
                    ) ms ON ms.ID_MATRICULA = m.ID_MATRICULA;
                """;

                using SqlCommand cmdUpdateMatricula = new(updateMatriculasql, conexao, transacao);
                cmdUpdateMatricula.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception)
            {
                if (transacao?.Connection != null)
                    transacao.Rollback();
                throw;
            }
        }

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
                cmdMensalidade.Parameters.Add("@pago", SqlDbType.Int).Value = pago;

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

        public void AlterarTudo(int idMatricula, int idAluno, int idTurma, DateTime venc, bool situacao)
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
                        VENCIMENTO = @venc
                        WHERE ID_MATRICULA = @idMatricula;

                    UPDATE Mensalidade
                    SET DATA_VENCIMENTO = @venc
                    WHERE ID_MATRICULA = @idMatricula;
                """;

                using SqlCommand cmdMatricula = new(sqlMatricula, conexao, transacao);
                cmdMatricula.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
                cmdMatricula.Parameters.Add("@idAluno", SqlDbType.Int).Value = idAluno;
                cmdMatricula.Parameters.Add("@idTurma", SqlDbType.Int).Value = idTurma;
                cmdMatricula.Parameters.Add("@venc", SqlDbType.Date).Value = venc;

                cmdMatricula.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception)
            {
                if (transacao?.Connection != null)
                    transacao.Rollback();
                throw;
            }
        }

        public void InativarMatricula(int idMatricula)
        {
            SqlTransaction? transacao = null;

            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                transacao = conexao.BeginTransaction();

                string InativarMatriculasql = """
                    UPDATE Matricula
                    SET SITUACAO = 0
                    WHERE ID_MATRICULA = @idMatricula
                """;

                using SqlCommand cmdInativar = new(InativarMatriculasql, conexao, transacao);
                cmdInativar.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
                cmdInativar.ExecuteNonQuery();

                string cancelarMensalidadesSql = """
                    UPDATE Mensalidade
                    SET SITUACAO = 2
                    WHERE ID_MATRICULA = @idMatricula
                        AND SITUACAO = 0
                """;

                using SqlCommand cmdCancelar = new(cancelarMensalidadesSql, conexao, transacao);
                cmdCancelar.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;

                cmdCancelar.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception)
            {
                if (transacao?.Connection != null)
                    transacao.Rollback();
                throw;
            }
        }

        public void ReativarMatricula(int idMatricula, DateTime venc)
        {
            SqlTransaction? transacao = null;

            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                transacao = conexao.BeginTransaction();

                string sql = """
                    UPDATE Matricula
                    SET SITUACAO = 1
                    WHERE ID_MATRICULA = @idMatricula
                """;

                using SqlCommand cmdReativar = new(sql, conexao, transacao);
                cmdReativar.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
                cmdReativar.ExecuteNonQuery();

                string ajustarMensalidadesSql = """                   
                    UPDATE Mensalidade
                    SET SITUACAO = 0
                    WHERE ID_MATRICULA = @idMatricula
                        AND SITUACAO = 2
                        AND YEAR(DATA_VENCIMENTO) = YEAR(@venc)
                        AND MONTH(DATA_VENCIMENTO) = MONTH(@venc);
                
                    IF @@ROWCOUNT = 0
                    BEGIN
                        INSERT INTO Mensalidade (ID_MATRICULA, DATA_VENCIMENTO, SITUACAO)
                        VALUES (@idMatricula, @venc, 0);
                    END
              
                    UPDATE Matricula
                    SET VENCIMENTO = @venc
                    WHERE ID_MATRICULA = @idMatricula;
                """;

                using SqlCommand cmdAjustar = new(ajustarMensalidadesSql, conexao, transacao);
                cmdAjustar.Parameters.Add("@idMatricula", SqlDbType.Int).Value = idMatricula;
                cmdAjustar.Parameters.Add("@venc", SqlDbType.Date).Value = venc;
                cmdAjustar.ExecuteNonQuery();

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
