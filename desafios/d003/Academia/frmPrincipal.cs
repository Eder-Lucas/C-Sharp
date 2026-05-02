using Microsoft.Data.SqlClient;
using System.Data;

namespace Academia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private readonly Caixa novoCaixa = new();

        private readonly ucProfessores professores = new();
        private readonly ucModalidades modalidades = new();
        private readonly ucTurmas turmas = new();
        private readonly ucConfiguracoes configuracoes = new();
        private readonly ucAlunos alunos = new();
        private ucCaixa? caixa = null;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Estabelece a conexão com o banco de dados através da classe Conexao e seu método StringConexao
            using SqlConnection novaConexao = new(Conexao.StringConexao);

            try
            {
                Navegacao.PanelPrincipal = pnlConteudo;

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

        // Linkando aos formulários
        private void btnProfessor_Click(object sender, EventArgs e)
        {
            Navegacao.AbrirUc(professores);
        }

        private void btnModalidades_Click(object sender, EventArgs e)
        {
            Navegacao.AbrirUc(modalidades);
        }

        private void btnTurmas_Click(object sender, EventArgs e)
        {
            Navegacao.AbrirUc(turmas);
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            caixa ??= new ucCaixa(this);
            Navegacao.AbrirUc(caixa);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Navegacao.AbrirUc(configuracoes);
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            Navegacao.AbrirUc(alunos);
        }

        // Manipula a visualização do label dependendo da situação do caixa
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
