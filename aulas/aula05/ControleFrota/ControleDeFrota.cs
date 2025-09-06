namespace ControleFrota
{
    public partial class ControleDeFrota : Form
    {
        public ControleDeFrota()
        {
            InitializeComponent();
        }

        public class Veiculo
        {
            private string modelo, placa, km;

            public void salvaModelo(string modelo)
            {
                this.modelo = modelo;
            }

            public void salvaPlaca(string placa)
            {
                this.placa = placa;
            }

            public void salvaKm(string km)
            {
                this.km = km;
            }

            public string mostraModelo()
            {
                return modelo;
            }

            public string mostraPlaca()
            {
                return placa;
            }

            public string mostraKm()
            {
                return km;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Veiculo novoCarro = new Veiculo();

            novoCarro.salvaModelo(txtModelo.Text);
            novoCarro.salvaPlaca(txtPlaca.Text);
            novoCarro.salvaKm(txtKm.Text);

            txtCarros.Text += novoCarro.mostraModelo() + "\t";
            txtCarros.Text += novoCarro.mostraPlaca() + "\t";
            txtCarros.Text += novoCarro.mostraKm() + "\r\n";
        }
    }
}
