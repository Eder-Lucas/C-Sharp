using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Academia
{
    internal class Horarios
    {
        public void Salvar(int idHorario, int idTurma, int diaSemana, TimeSpan inicio, TimeSpan fim)
        {
            if (inicio >= fim)
                throw new Exception("O horário de início deve ser menor que o horário término.");

            if (ExisteHorarioIgual(idHorario, idTurma, diaSemana, inicio, fim))
                throw new Exception("Já existe um horário cadastrado para esta turma");

            if (idHorario == 0)
                Inserir(idTurma, diaSemana, inicio, fim);
            else
                Atualizar(idHorario, idTurma, diaSemana, inicio, fim);
        }

        public void Inserir(int idTurma, int diaSemana, TimeSpan inicio, TimeSpan fim)
        {
			try
			{
				using SqlConnection conexao = new SqlConnection(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    INSERT INTO Horario (ID_TURMA, DIA_SEMANA, INICIO, FIM)
                    VALUES (@idTurma, @diaSemana, @inicio, @fim)
                """;

                using SqlCommand cmd = new(sql, conexao);

                cmd.Parameters.Add("@idTurma", SqlDbType.Int).Value = idTurma;
                cmd.Parameters.Add("@diaSemana", SqlDbType.Int).Value = diaSemana;
                cmd.Parameters.Add("@inicio", SqlDbType.Time).Value = inicio;
                cmd.Parameters.Add("@fim", SqlDbType.Time).Value = fim;

                cmd.ExecuteNonQuery();
            }
			catch (Exception)
			{
				throw;
			}
        }

        public void Atualizar(int idHorario, int idTurma, int diaSemana, TimeSpan inicio,TimeSpan fim)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    UPDATE Horario
                    SET ID_TURMA = @idTurma,
                        DIA_SEMANA = @diaSemana,
                        INICIO = @inicio,
                        FIM = @fim
                    WHERE ID_HORARIO = @idHorario
                """;

                using SqlCommand cmd = new(sql, conexao);

                cmd.Parameters.Add("@idTurma", SqlDbType.Int).Value = idTurma;
                cmd.Parameters.Add("@diaSemana", SqlDbType.Int).Value = diaSemana;
                cmd.Parameters.Add("@inicio", SqlDbType.Time).Value = inicio;
                cmd.Parameters.Add("@fim", SqlDbType.Time).Value = fim;
                cmd.Parameters.Add("@idHorario", SqlDbType.Int).Value = idHorario;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Excluir(int idHorario)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    DELETE FROM Horario
                    WHERE ID_HORARIO = @idHorario
                """;

                using SqlCommand cmd = new(sql, conexao);

                cmd.Parameters.Add("@idHorario", SqlDbType.Int).Value = idHorario;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Listar(int idTurma)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT h.*, t.ID_TURMA
                    FROM Horario h
                    INNER JOIN Turma t ON h.ID_TURMA = t.ID_TURMA
                    WHERE h.ID_TURMA = @idTurma
                    ORDER BY h.ID_TURMA DESC
                """;

                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@idTurma", SqlDbType.Int).Value = idTurma;

                DataTable tabela = new();
                tabela.Load(cmd.ExecuteReader());

                return tabela;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ExisteHorarioIgual(int idHorario, int idTurma, int diaSemana, TimeSpan inicio, TimeSpan fim)
        {
            try
            {
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

                string sql = """
                    SELECT 1 FROM Horario
                    WHERE ID_TURMA = @idTurma
                    AND DIA_SEMANA = @diaSemana
                    AND @inicio < FIM
                    AND @fim > INICIO
                """;

                if (idHorario > 0)
                    sql += " AND ID_HORARIO <> @idHorario";
                
                using SqlCommand cmd = new(sql, conexao);
                cmd.Parameters.Add("@idTurma", SqlDbType.Int).Value = idTurma;
                cmd.Parameters.Add("@diaSemana", SqlDbType.Int).Value = diaSemana;
                cmd.Parameters.Add("@inicio", SqlDbType.Time).Value = inicio;
                cmd.Parameters.Add("@fim", SqlDbType.Time).Value = fim;
                if (idHorario > 0)
                    cmd.Parameters.Add("@idHorario", SqlDbType.Int).Value = idHorario;

                using SqlDataReader leitor = cmd.ExecuteReader();
                return leitor.HasRows;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
