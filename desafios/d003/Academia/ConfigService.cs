using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academia
{
    internal class ConfigService
    {
        private static string? Get(string chave)
        {
			try
			{
				using SqlConnection conexao = new(Conexao.StringConexao);
				conexao.Open();

				string sql = """
					SELECT VALOR
					FROM Configuracoes
					WHERE CHAVE = @chave
				""";

				using SqlCommand cmd = new(sql, conexao);
				cmd.Parameters.Add("@chave", System.Data.SqlDbType.VarChar, 225).Value = chave;

				return cmd.ExecuteScalar().ToString(); // retornando valor
            }
			catch (Exception)
			{
				throw;
			}
        }

		public static void Set(string chave, string valor)
		{
			SqlTransaction? transacao = null;

            try
			{
                using SqlConnection conexao = new(Conexao.StringConexao);
                conexao.Open();

				transacao = conexao.BeginTransaction();

                string sqlTipo = "SELECT TIPO FROM Configuracoes WHERE CHAVE = @chave";

                using SqlCommand cmdTipo = new(sqlTipo, conexao, transacao);
                cmdTipo.Parameters.AddWithValue("@chave", chave);

                string tipo = (string)cmdTipo.ExecuteScalar();

                if (tipo == null)
                    throw new Exception("Configuração não encontrada");

                // valida o tipo
                switch (tipo)
                {
                    case "INT":
                        if (!int.TryParse(valor, out _))
                            throw new Exception("Valor inválido para INT");
                        break;

                    case "BOOL":
                        if (!bool.TryParse(valor, out _))
                            throw new Exception("Valor inválido para BOOL");
                        break;

                    case "DECIMAL":
                        if (!decimal.TryParse(valor, out _))
                            throw new Exception("Valor inválido para DECIMAL");
                        break;
                }

				string sql = """
					UPDATE Configuracoes
					SET VALOR = @valor
					WHERE CHAVE = @chave
				""";

				using SqlCommand cmd = new(sql, conexao, transacao);
				cmd.Parameters.Add("@chave", System.Data.SqlDbType.VarChar, 225).Value = chave;
				cmd.Parameters.Add("@valor", System.Data.SqlDbType.VarChar, 225).Value = valor;

				cmd.ExecuteNonQuery();

				transacao.Commit();
            }
			catch (Exception)
			{
                if (transacao != null)
					transacao.Rollback();
                throw;
			}
        }

        public static bool GetBool(string chave)
		{
			try
			{
				return Convert.ToBoolean(Get(chave));
			}
			catch (Exception)
			{
				throw;
			}
		}
    }
}
