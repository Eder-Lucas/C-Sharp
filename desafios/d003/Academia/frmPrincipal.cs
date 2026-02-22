using Microsoft.Data.SqlClient;

namespace Academia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // Evento Load do formulário principal
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Estabelece a conexão com o banco de dados através da classe Conexao e seu método StringConexao
            using SqlConnection novaConexao = new(Conexao.StringConexao);

            try
            {
                novaConexao.Open(); // Abre a conexão com o banco
                MessageBox.Show("Conexão com o banco de dados realizada!"); // Mensagem de sucesso caso a conexão seja estabelecida
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar se conectar ao banco de dados!"); // Mensagem de erro caso a conexão falhe
            }
            finally
            {
                MessageBox.Show("Bem Vindo ao sistema de academia!");
            }
        }
    }
}
