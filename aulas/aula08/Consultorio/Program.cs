using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //usando variável de ambiente para configurar a connection string do banco de dados
            //útil apenas quando o projeto tiver em DESENVOLVIMENTO
            //em PRODUÇÃO é necessário criptografar os dados de .exe.config

            //pega a connection string a partir da variável de ambiente chamada "CONNECTION_DB"
            var cs = Environment.GetEnvironmentVariable("CONNECTION_DB");

            //verifica se a variável de ambiente não está vazia ou nula
            if (!string.IsNullOrWhiteSpace(cs))
            {
                //abre o arquivo de configuração do executável (exe.config) para leitura e escrita
                var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(
                    System.Configuration.ConfigurationUserLevel.None
                );

                //acessa a connection string específica do TableAdapter/DataSet
                //esse é o nome que o Visual Studio gera automaticamente
                var connect = config.ConnectionStrings.ConnectionStrings["Consultorio.Properties.Settings.ConsultasConnectionString"];

                //verifica se a connection string existe
                if (connect != null)
                {
                    //substitui o valor antigo pelo valor da variável de ambiente
                    connect.ConnectionString = cs;

                    //salva a alteração no arquivo exe.config
                    config.Save(System.Configuration.ConfigurationSaveMode.Modified);

                    //atualiza a seção "connectionStrings" em memória para que a mudança tenha efeito imediato
                    System.Configuration.ConfigurationManager.RefreshSection("connectionStrings");
                }
            }

            //executa o formulário principal do sistema
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
