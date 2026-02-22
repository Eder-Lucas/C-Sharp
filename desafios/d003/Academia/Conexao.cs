using System;
using System.Collections.Generic;
using System.Text;

namespace Academia
{
    internal class Conexao
    {
        private static readonly string conexao = Environment.GetEnvironmentVariable("DB_CONNECTION")!;

        public static string StringConexao
        {
            get
            {
                if (string.IsNullOrEmpty(conexao))
                {
                    throw new InvalidOperationException("A string de conexão não pode ser nula ou vazia.");
                }

                return conexao;
            }

        }
    }
}
