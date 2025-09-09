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
            /* se n�o usasse as propriedades
            
            // recebe como par�metro uma string chamada modelo 
            public void salvaModelo(string modelo)
            {
                this.modelo = modelo; //o atributo modelo recebe o valor vindo do par�metro
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

            private string modelo, placa, km; //define os atributos da class

            //propriedade modelo do veiculo
            public string PropriedadeModelo
            {
                //forma resumida para salvar e mostrar dados
                set { modelo = value; } //salva o modelo
                get { return modelo; } //retorna o valor, fazendo possivel mostrar ele em determinado local
            }

            //propriedade placa
            public string PropriedadePlaca
            {
                set { placa = value; }
                get { return placa; }
            }

            //propriedade km
            public string PropriedadeKm
            {
                set { km = value; }
                get { return km; }
            }
        }

        //classe filha de veiculos
        //herda: Modelo, Placa e Km por ser filha
        public class Caminhao : Veiculo
        {
            //propriedade que diferencia um carro de caminh�o
            public string PropriedadeEixo { set; get; } //forma mais resumida para salvar e mostrar os valores
        }

        //quando clicar no bot�o caminhao
        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            //os campos de eixo ficam visiveis
            lblEixo.Visible = true;
            txtEixo.Visible = true;
        }

        //quando clicar no bot�o de carros
        private void btnCarros_Click(object sender, EventArgs e)
        {
            //os campos eixos ficam invisiveis
            lblEixo.Visible = false;
            txtEixo.Visible = false;
        }

        //fun��o que limpa os campos
        private void Limpar()
        {
            txtModelo.Clear();
            txtPlaca.Clear();
            txtKm.Clear();
            txtEixo.Clear();
        }

        //quando clicar no bot�o salvar
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

            //se o campo eixo nao tiver visivel
            if (!txtEixo.Visible)
            {
                //cria um novo objeto
                Veiculo novoCarro = new Veiculo();

                //adiciona valores ao seus atributos
                novoCarro.PropriedadeModelo = txtModelo.Text;
                novoCarro.PropriedadePlaca = txtPlaca.Text;
                novoCarro.PropriedadeKm = txtKm.Text;

                //exibe no txt referente aos carros
                txtCarros.AppendText(novoCarro.PropriedadeModelo + "\t"); //AppendText � o mesmo que txtCarros.Text +=
                txtCarros.AppendText(novoCarro.PropriedadePlaca + "\t");
                txtCarros.AppendText(novoCarro.PropriedadeKm + "\r\n");
            }

            //se o campo eixo estiver visivel
            else
            {
                //cria um novo objeto, dessa vez para caminhao
                Caminhao novoCaminhao = new Caminhao
                {
                    //atribui valores
                    PropriedadeModelo = txtModelo.Text,
                    PropriedadePlaca = txtPlaca.Text,
                    PropriedadeKm = txtKm.Text,
                    PropriedadeEixo = txtEixo.Text
                };

                //exibe no txt referente aos caminhoes
                txtCaminhao.AppendText(novoCaminhao.PropriedadeModelo + "\t");
                txtCaminhao.AppendText(novoCaminhao.PropriedadePlaca + "\t");
                txtCaminhao.AppendText(novoCaminhao.PropriedadeKm + "\t");
                txtCaminhao.AppendText(novoCaminhao.PropriedadeEixo + "\r\n");
            }

            //chama a fun��o que limpa os campos ap�s exibir os valores nos textBox
            Limpar();
        }

    }
}
