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
            this.DoubleBuffered = true;

            InicializaIcones();
        }

        private readonly Caixa novoCaixa = new();

        private readonly ucProfessores professores = new();
        private readonly ucModalidades modalidades = new();
        private readonly ucTurmas turmas = new();
        private readonly ucConfiguracoes configuracoes = new();
        private readonly ucAlunos alunos = new();
        private ucCaixa? caixa = null;
        private readonly ucHome home = new();

        private Dictionary<Button, (Image normal, Image ativo)> icones;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Estabelece a conexão com o banco de dados através da classe Conexao e seu método StringConexao
            using SqlConnection novaConexao = new(Conexao.StringConexao);

            try
            {
                Navegacao.PanelPrincipal = pnlConteudo;

                novaConexao.Open();

                MatriculaService matriculaService = new();
                matriculaService.GerarMensalidade();

                VerificaSituacaoCaixa();

                Navegacao.AbrirUc(home);
                SelecionaBotao(btnHome);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar se conectar ao banco de dados: {ex.Message}");
            }
        }

        // Linkando aos formulários
        private void btnAluno_Click(object sender, EventArgs e)
        {
            Navegacao.AbrirUc(alunos);

            SelecionaBotao(btnAluno);
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            Navegacao.AbrirUc(professores);

            SelecionaBotao(btnProfessor);
        }

        private void btnModalidade_Click(object sender, EventArgs e)
        {
            Navegacao.AbrirUc(modalidades);

            SelecionaBotao(btnModalidade);
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            Navegacao.AbrirUc(turmas);

            SelecionaBotao(btnTurma);
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            caixa ??= new ucCaixa(this);
            Navegacao.AbrirUc(caixa);

            SelecionaBotao(btnCaixa);
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            Navegacao.AbrirUc(configuracoes);

            SelecionaBotao(btnConfiguracao);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Navegacao.AbrirUc(home);
            SelecionaBotao(btnHome);
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
                    lblCaixa.ForeColor = Color.FromArgb(68, 255, 68);
                }
                else
                {
                    lblCaixa.Text = "FECHADO";
                    lblCaixa.ForeColor = Color.FromArgb(247, 68, 68);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelecionaBotao(Button btnSelecionado)
        {
            foreach (var item in icones)
            {
                item.Key.ForeColor = SystemColors.ControlDark;
                item.Key.Image = item.Value.normal;
                item.Key.BackColor = Color.FromArgb(9, 0, 94);
            }

            btnSelecionado.ForeColor = SystemColors.ButtonHighlight;
            btnSelecionado.Image = icones[btnSelecionado].ativo;
            btnSelecionado.BackColor = Color.FromArgb(36, 36, 163);

            pnlDecoração.Visible = true;
            pnlDecoração.Height = btnSelecionado.Height;
            pnlDecoração.Top = btnSelecionado.Top;

            btnSelecionado.Refresh();
        }


        private void InicializaIcones()
        {
            icones = new Dictionary<Button, (Image, Image)>
            {
                { btnAluno, (Properties.Resources.alunosIcon_cinza, Properties.Resources.alunosIcon_branco) },
                { btnProfessor, (Properties.Resources.professoresIcon_cinza, Properties.Resources.professoresIcon_branco) },
                { btnModalidade, (Properties.Resources.modalidadesIcon_cinza, Properties.Resources.modalidadesIcon_branco) },
                { btnTurma, (Properties.Resources.turmasIcon_cinza, Properties.Resources.turmasIcon_branco) },
                { btnCaixa, (Properties.Resources.caixaIcon_cinza, Properties.Resources.caixaIcon_branco) },
                { btnConfiguracao, (Properties.Resources.configuracaoIcon_cinza, Properties.Resources.configuracaoIcon_branco) },
                { btnHome, (Properties.Resources.inicioIcon_cinza, Properties.Resources.inicioIcon_branco) }
            };
        }
    }
}
