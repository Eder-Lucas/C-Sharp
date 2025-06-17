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
    }
}
