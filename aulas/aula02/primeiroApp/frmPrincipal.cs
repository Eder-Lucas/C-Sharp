namespace primeiroApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Botao Mostrar Mensagem
        private void btnMostrarMensagem_Click(object sender, EventArgs e) //evento click
        {
            lblMensagem.Text = "Primeiro Aplicativo em C-Sharp"; //define o texto que vai ser mostrado
            lblMensagem.ForeColor = Color.Magenta; //muda a cor do label para magenta
            btnImagens.Enabled = true;
            btnTabuada.Enabled = true;
            btnPropriedadesCheckBox.Enabled = true;
        }

        //Botao CheckBox
        private void btnPropriedadesCheckBox_Click(object sender, EventArgs e)
        {
            frmPropriedadesCheckBox propriedades = new frmPropriedadesCheckBox(); //istanciacao
            propriedades.ShowDialog(); //mostra o formulario CheckBox
        }

        //Botao Imagens
        private void btnImagens_Click(object sender, EventArgs e)
        {
            frmVizualizadorImagens imagens = new frmVizualizadorImagens();
            imagens.ShowDialog();
        }

        //Botao Tabuada
        private void btnTabuada_Click(object sender, EventArgs e)
        {
            frmTabuada tabuada = new frmTabuada();
            tabuada.ShowDialog();
        }

        //Comportamento ao entrar o mouse em algum botao
        private void botao_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Cursor = Cursors.Hand; //Adiciona o cursor 'Maozinha'
        }

        //Comportamento ao tirar o mouse de algum botao
        private void botao_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Cursor = Cursors.Default; //Adiciona o cursor padrao
        }

        //Assim que o frmPrincipal for carregado
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Percorre todos os controles do formulário
            foreach (Control con in this.Controls)
            {
                if (con is Button btn) //Se for um botao
                {
                    //Associa os evento do mouse
                    btn.MouseEnter += botao_MouseEnter;
                    btn.MouseLeave += botao_MouseLeave;
                }
            }
        }
    }
}
