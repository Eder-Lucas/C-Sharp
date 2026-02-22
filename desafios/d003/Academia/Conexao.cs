using System;
using System.Collections.Generic;
using System.Text;

namespace Academia
{
    // Classe responsável por fornecer a string de conexão para o banco de dados
    internal class Conexao
    {
        // A string de conexão é obtida a partir de uma variável de ambiente chamada "DB_CONNECTION"
        private static readonly string conexao = Environment.GetEnvironmentVariable("DB_CONNECTION")!;

        // Método público para acessar a string de conexão
        public static string StringConexao
        {
            // Get retorna a string de conexão, mas antes verifica se ela é nula ou vazia,
            // lançando uma exceção caso seja
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
