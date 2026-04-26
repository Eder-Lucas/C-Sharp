using Microsoft.Data.SqlClient;
using System.Data;

namespace Academia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private readonly Caixa novoCaixa = new();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Estabelece a conexão com o banco de dados através da classe Conexao e seu método StringConexao
            using SqlConnection novaConexao = new(Conexao.StringConexao);

            try
            {
                novaConexao.Open(); 
                MessageBox.Show("Conexão com o banco de dados realizada!"); 

                MatriculaService matriculaService = new();
                matriculaService.GerarMensalidade();

                VerificaSituacaoCaixa();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar se conectar ao banco de dados: {ex.Message}"); 
            }
            // Executa sempre
            finally
            {
                MessageBox.Show("Bem Vindo ao sistema de academia!"); 
            }
        }

        private void btnProfessor_Click(object sender, EventArgs e) => new frmProfessores().ShowDialog();
        private void btnModalidades_Click(object sender, EventArgs e) => new frmModalidades().ShowDialog();
        private void btnTurmas_Click(object sender, EventArgs e) => new frmTurmas().ShowDialog();
        private void btnAlunos_Click(object sender, EventArgs e) => new frmAlunos().ShowDialog();
        private void btnCaixa_Click(object sender, EventArgs e) => new frmCaixa(this).ShowDialog();
        private void btnConfig_Click(object sender, EventArgs e) => new frmConfig().ShowDialog();

        public void VerificaSituacaoCaixa()
        {
            try
            {
                DataTable dadosCaixa = novoCaixa.Listar();
                bool situacaoCaixa = Convert.ToBoolean(dadosCaixa.Rows[0]["SITUACAO"]);

                if (situacaoCaixa)
                {
                    lblCaixa.Text = "ABERTO";
                    lblCaixa.ForeColor = Color.DarkGreen;
                }
                else
                {
                    lblCaixa.Text = "FECHADO";
                    lblCaixa.ForeColor= Color.Firebrick;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
