namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        double valorVisor, valorAnterior;
        string operacao = "";
        bool primeiraOperacao = true, botaoIgual = false;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void ClicouBotao_Click(object sender, EventArgs e)
        {
            //txtVisor.Text += "1";      

            if (txtVisor.Text == "0" || botaoIgual == true)
            {
                txtVisor.Clear();
                botaoIgual = false;
            }

            Button botaoClicado = (Button)sender;

            switch (botaoClicado.Name)
            {
                case "btn1":
                    txtVisor.Text += "1";
                    break;

                case "btn2":
                    txtVisor.Text += "2";
                    break;

                case "btn3":
                    txtVisor.Text += "3";
                    break;

                case "btn4":
                    txtVisor.Text += "4";
                    break;

                case "btn5":
                    txtVisor.Text += "5";
                    break;

                case "btn6":
                    txtVisor.Text += "6";
                    break;

                case "btn7":
                    txtVisor.Text += "7";
                    break;

                case "btn8":
                    txtVisor.Text += "8";
                    break;

                case "btn9":
                    txtVisor.Text += "9";
                    break;

                case "btn0":
                    txtVisor.Text += "0";
                    break;

                case "btnVirgula":
                    if (txtVisor.Text == "")
                    {
                        txtVisor.Text += "0,";
                    }
                    else
                    {
                        txtVisor.Text += ",";
                    }
                    break;

                default:
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
            txtHistorico.Clear();

            valorAnterior = 0;
            valorVisor = 0;

            operacao = "";
            primeiraOperacao = true;
            botaoIgual = false;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);
            if (txtVisor.Text.Length == 1)
            {
                txtVisor.Text = "0";              
            }
            else
            {
                txtVisor.Text = txtVisor.Text[..^1];
            }
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            operacao = " + ";

            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text;
                }

                txtVisor.Clear();
                
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txtVisor.Text);
                txtHistorico.Text += operacao + txtVisor.Text;

                txtVisor.Text = Convert.ToString(valorAnterior + valorVisor);

                txtHistorico.Text += " = " + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }
    }
}
