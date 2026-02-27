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

            // Tenta abrir a conexão com o banco de dados
            try
            {
                novaConexao.Open(); // Abre a conexão com o banco
                MessageBox.Show("Conexão com o banco de dados realizada!"); // Mensagem de sucesso caso a conexão seja estabelecida
            }
            // Se falhar captura o erro e exibe uma mensagem de falha
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar se conectar ao banco de dados!"); // Mensagem de erro caso a conexão falhe
            }
            // Executa sempre, independentemente do sucesso ou falha da conexão
            finally
            {
                MessageBox.Show("Bem Vindo ao sistema de academia!"); // Exibe independente do resultado da conexão
            }
        }

        private void btnProfessor_Click(object sender, EventArgs e) => new frmProfessores().ShowDialog();

        private void btnModalidades_Click(object sender, EventArgs e) => new frmModalidades().ShowDialog();
    }
}
