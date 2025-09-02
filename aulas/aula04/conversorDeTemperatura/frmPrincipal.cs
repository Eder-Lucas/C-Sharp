using System.Runtime.CompilerServices;

namespace conversorDeTemperatura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);

            if (rbCelsius1.Checked == true)
            {
                if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = (valor + 273) + "K";
                }
                else if (rbFahrenheit2.Checked == true)
                {
                    txtResultado.Text = (valor * 1.8 + 32) + "�F";
                }
                else
                {
                    txtResultado.Text = valor + "�C";
                }
            }
            else if (rbKelvin1.Checked == true)
            {
                if (rbCelsius2.Checked == true)
                {
                    txtResultado.Text = (valor - 273) + "�C";
                }
                else if (rbFahrenheit2.Checked == true)
                {
                    txtResultado.Text = (valor * 1.8 - 459.67) + "�F";
                }
                else
                {
                    txtResultado.Text = valor + "K";
                }
            }
            else if (rbFahrenheit1.Checked == true)
            {
                if (rbCelsius2.Checked == true)
                {
                    txtResultado.Text = ((valor - 32) / 1.8) + "�C";
                }
                else if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = ((valor + 459.67) / 1.8) + "�C";
                }
                else
                {
                    txtResultado.Text = valor + "�F";
                }
            }
            else
            {
                txtResultado.Text = valor.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //this representa o pr�prio formul�rio, ou seja, o container principal
            //Ent�o o m�todo vai come�ar a percorrer todos os controles dentro do formul�rio
            limpaControles(this);     
        }

        private void limpaControles(Control parent) //recebe um controle que pode conter "Filhos"
        {
            //percorre cada controle filho do parent armazenando em 'c' a cada loop
            foreach (Control c in parent.Controls)
            {
                //verifica��o com switch case para cada tipo de controle
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
                //chama a fun��o novamente passando esse controle como par�metro
                //esse m�todo � chamado de fun��o recursiva
                if (c.HasChildren) limpaControles(c);
            }
        }
    }
}
