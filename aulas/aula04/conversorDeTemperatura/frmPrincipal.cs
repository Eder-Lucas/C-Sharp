using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace conversorDeTemperatura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private ErrorProvider errorProvider = new ErrorProvider();
        private void buttonConverter_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(txtValor.Text, out _))
            {
                errorProvider.SetError(txtValor, "Adicione um valor");
                return;
            }

            errorProvider.SetError(txtValor, "");

            double valor = Convert.ToDouble(txtValor.Text);
            double resultado = valor;
            string unidade = "";

            if (rbCelsius1.Checked)
            {
                if (rbKelvin2.Checked)
                {
                    resultado = (valor + 273);
                    unidade = "K";
                }
                else if (rbFahrenheit2.Checked)
                {
                    resultado = (valor * 1.8 + 32);
                    unidade = "°F";
                }
            }

            else if (rbKelvin1.Checked)
            {
                if (rbCelsius2.Checked)
                {
                    resultado = (valor - 273);
                    unidade = "°C";
                }
                else if (rbFahrenheit2.Checked)
                {
                    resultado = (valor * 1.8 - 459.67);
                    unidade = "°F";
                }
            }

            else if (rbFahrenheit1.Checked)
            {
                if (rbCelsius2.Checked)
                {
                    resultado = ((valor - 32) / 1.8);
                    unidade = "°C";
                }
                else if (rbKelvin2.Checked)
                {
                    resultado = ((valor + 459.67) / 1.8);
                    unidade = "K";
                }
            }

            txtResultado.Text = resultado.ToString("F2") + unidade; 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //this representa o próprio formulário, ou seja, o container principal
            //Então o método vai começar a percorrer todos os controles dentro do formulário
            limpaControles(this);     
        }

        private void limpaControles(Control parent) //recebe um controle que pode conter "Filhos"
        {
            //percorre cada controle filho do parent armazenando em 'c' a cada loop
            foreach (Control c in parent.Controls)
            {
                //verificação com switch case para cada tipo de controle
                switch(c)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case RadioButton rb:
                        rb.Checked = false;
                        break;
                }

                //se o controle tiver outros controles dentro (Panel, GrupoBox e etc)
                //chama a função novamente passando esse controle como parâmetro
                //esse método é chamado de função recursiva
                if (c.HasChildren) limpaControles(c);
            }
        }
    }
}
