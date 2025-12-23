namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        decimal valorVisor, valorAnterior;
        string operacao = "";
        bool primeiraOperacao = true, botaoIgual = false, podeApagar = false;

        public frmCalculadora()
        {
            InitializeComponent();
        }


        //ao clicar no botão limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
            txtHistorico.Clear();

            valorAnterior = 0;
            valorVisor = 0;

            operacao = "";
            primeiraOperacao = true;
            botaoIgual = false;
            podeApagar = false;
        } 

        //ao clicar no botão de backSpace
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

        //ao clicar no botão de igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (botaoIgual || string.IsNullOrEmpty(operacao))
            {
                return;
            }

            RemoveUltimoOperador();

            valorVisor = Convert.ToDecimal(txtVisor.Text);

            txtHistorico.Text += operacao + txtVisor.Text;

            //instância a classe criando um novo objeto
            ObjetoCalculo novoCalculo = new ObjetoCalculo();

            //atribui os valores das variáveis às propriedades do objeto
            novoCalculo.valorVisor = this.valorVisor;
            novoCalculo.valorAnterior = this.valorAnterior;
            novoCalculo.operacao = this.operacao;

            //chama o método Calculo atribuindo seu retorno ao txtVisor
            txtVisor.Text = Convert.ToString(novoCalculo.Calculo());

            txtHistorico.Text += " = " + txtVisor.Text;

            valorAnterior = Convert.ToDecimal(txtVisor.Text);

            botaoIgual = true;
            podeApagar = true;
            primeiraOperacao = false;
            operacao = "";
        }

        private void RemoveUltimoOperador()
        {
            string[] operadores = [" + ", " - ", " x ", " ÷ "];

            foreach (string op in operadores)
            {
                if (txtHistorico.Text.EndsWith(op))
                {
                    txtHistorico.Text = txtHistorico.Text[..^3];
                    break;
                }
            }         
        }

        //Adiciona valor ao clicar nos botões númericos
        private void ClicouBotao_Click(object sender, EventArgs e)
        {
            //txtVisor.Text += "1";      

            if (txtVisor.Text == "0" || podeApagar == true)
            {
                txtVisor.Clear();
                podeApagar = false;
            }

            Button botaoClicado = (Button)sender;

            if (botaoClicado.Tag.ToString() == ",")
            {
                if (!txtVisor.Text.Contains(","))
                {
                    if (string.IsNullOrEmpty(txtVisor.Text))
                        txtVisor.Text = "0,";
                    else
                        txtVisor.Text += ",";
                }
            }
            else
            {
                txtVisor.Text += botaoClicado.Tag.ToString();
            }

            /* usando switch
             * 
             * switch (botaoClicado.Name)
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
            */
        }
        

        /* Método Cálculo antigo sem usar classe
         * esse método agora está no arquivo: ObjetoCalculo.cs
        public decimal Calculo(string operacao)
        {
            switch (operacao)
            {
                case " + ":
                    valorAnterior += valorVisor;
                    break;

                case " - ":
                    valorAnterior -= valorVisor;
                    break;

                case " x ":
                    valorAnterior *= valorVisor;
                    break;

                case " ÷ ":
                    valorAnterior /= valorVisor;
                    break;

                default:
                    break;
            }

            return Math.Round(valorAnterior, 2);
        }
        */


        //lógica central da calculadora
        public string Efetuacao(string operacao)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDecimal(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text + operacao;
                }

                txtVisor.Clear();

                primeiraOperacao = false;
            }
            else
            {
                RemoveUltimoOperador();

                txtHistorico.Text += operacao + txtVisor.Text;

                valorVisor = Convert.ToDecimal(txtVisor.Text);

                //txtVisor.Text = Convert.ToString(Calculo(operacao)); << sem usar classe

                //instância a classe criando um novo objeto
                ObjetoCalculo novoCalculo = new ObjetoCalculo();

                //atribui os valores das variáveis às propriedades do objeto
                novoCalculo.valorVisor = this.valorVisor;
                novoCalculo.valorAnterior = this.valorAnterior;
                novoCalculo.operacao = operacao;

                //chama o método Calculo atribuindo seu retorno ao txtVisor
                txtVisor.Text = Convert.ToString(novoCalculo.Calculo());

                txtHistorico.Text += " = " + txtVisor.Text;
                valorAnterior = Convert.ToDecimal(txtVisor.Text);
                podeApagar = true;
            }

            return operacao;
        }

        //ao clicar nos botões de operação
        private void btnAdicao_Click(object sender, EventArgs e)
        {
            operacao = Efetuacao(" + ");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            operacao = Efetuacao(" - ");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operacao = Efetuacao(" x ");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacao = Efetuacao(" ÷ ");
        }
    }
}
