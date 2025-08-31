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
                    txtResultado.Text = (valor * 1.8 + 32) + "�F";
                }
                else
                {
                    txtResultado.Text = valor + "�C";
                }

            }
        }
    }
}
