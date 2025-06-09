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
            lblMensagem.Text = "Primeiro Aplicativo em C-Sharp"; //adiciona o texto no label
            lblMensagem.ForeColor = Color.Purple; //muda a cor do label para roxo

        }
    }
}
