namespace conversorDeTemperatura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
                    txtResultado.Text = (valor * 1.8 + 32) + "ºF";
                }
                else
                {
                    txtResultado.Text = valor + "ºC";
                }
            }
            else if (rbKelvin1.Checked == true)
            {
                if (rbCelsius2.Checked == true)
                {
                    txtResultado.Text = (valor - 273) + "°C";
                }
                else if (rbFahrenheit2.Checked == true)
                {
                    txtResultado.Text = (valor * 1.8 - 459.67) + "°F";
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
                    txtResultado.Text = ((valor - 32) / 1.8) + "°C";
                }
                else if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = ((valor + 459.67) / 1.8) + "°C";
                }
                else
                {
                    txtResultado.Text = valor + "°F";
                }
            }
            else
            {
                txtResultado.Text = valor.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtResultado.Clear();

            foreach (Control Componente in gbEntrada.Controls)
            {
                if (Componente is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }

            foreach (Control Componente in gbSaida.Controls)
            {
                if (Componente is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }
        }
    }
}
