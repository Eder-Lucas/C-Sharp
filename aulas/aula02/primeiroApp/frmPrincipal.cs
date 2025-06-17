namespace primeiroApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMostrarMensagem_Click(object sender, EventArgs e) //evento click
        {
            lblMensagem.Text = "Primeiro Aplicativo em C-Sharp"; //define o texto que vai ser mostrado
            lblMensagem.ForeColor = Color.Magenta; //muda a cor do label para magenta

        }

        private void btnPropriedadesCheckBox_Click(object sender, EventArgs e) //ao clicar no botao CheckBox
        {
            frmPropriedadesCheckBox propriedades = new frmPropriedadesCheckBox(); //istanciacao
            propriedades.ShowDialog(); //mostra o formulario CheckBox
        }

        private void btnImagens_Click(object sender, EventArgs e)
        {
            frmVizualizadorImagens imagens = new frmVizualizadorImagens();
            imagens.ShowDialog();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            frmTabuada tabuada = new frmTabuada();
            tabuada.ShowDialog();
        }
    }
}
