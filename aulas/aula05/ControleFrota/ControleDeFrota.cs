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
            /* se não usasse as propriedades
            
            // recebe como parâmetro uma string chamada modelo 
            public void salvaModelo(string modelo)
            {
                this.modelo = modelo; //o atributo modelo recebe o valor vindo do parâmetro
            }

            public void salvaPlaca(string placa)
            {
                this.placa = placa;
            }

            public void salvaKm(string km)
            {
                this.km = km;
            }

            //mostrando 

            //metodo que retorna uma string
            public string mostraModelo()
            {
                return modelo; //retorna o valor guardado no metodo 'salvaModelo()'
            }

            public string mostraPlaca()
            {
                return placa;
            }

            public string mostraKm()
            {
                return km;
            }
            */

            //usando propriedades

            private string modelo, placa, km;

            public string propriedadeModelo
            {
                set { modelo = value; }
                get { return modelo; }
            }

            public string propriedadePlaca
            {
                set { placa = value; }
                get { return placa; }
            }

            public string propriedadeKm
            {
                set { km = value; }
                get { return km; }
            }
        }

        //classe filha de veiculos
        //herda: Modelo, Placa e Km por ser filha
        public class Caminhao : Veiculo
        {
            public string propriedadeEixo { set; get; }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /* se usasse atributos
            novoCarro.salvaModelo(txtModelo.Text);
            novoCarro.salvaPlaca(txtPlaca.Text);
            novoCarro.salvaKm(txtKm.Text);

            txtCarros.Text += novoCarro.mostraModelo() + "\t";
            txtCarros.Text += novoCarro.mostraPlaca() + "\t";
            txtCarros.Text += novoCarro.mostraKm() + "\r\n";
            */

            if (txtEixo.Visible == false)
            {
                Veiculo novoCarro = new Veiculo();

                novoCarro.propriedadeModelo = txtModelo.Text;
                novoCarro.propriedadePlaca = txtPlaca.Text;
                novoCarro.propriedadeKm = txtKm.Text;

                txtCarros.AppendText(novoCarro.propriedadeModelo + "\t");
                txtCarros.AppendText(novoCarro.propriedadePlaca + "\t");
                txtCarros.AppendText(novoCarro.propriedadeKm + "\r\n");
            }
            else
            {
                Caminhao novoCaminhao = new Caminhao();

                novoCaminhao.propriedadeModelo = txtModelo.Text;
                novoCaminhao.propriedadePlaca = txtPlaca.Text;
                novoCaminhao.propriedadeKm = txtKm.Text;
                novoCaminhao.propriedadeEixo = txtEixo.Text;

                txtCaminhao.AppendText(novoCaminhao.propriedadeModelo + "\t");
                txtCaminhao.AppendText(novoCaminhao.propriedadePlaca + "\t");
                txtCaminhao.AppendText(novoCaminhao.propriedadeKm + "\t");
                txtCaminhao.AppendText(novoCaminhao.propriedadeEixo + "\r\n");
            }
        }

        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            lblEixo.Visible = true;
            txtEixo.Visible = true;
        }
    }
}
