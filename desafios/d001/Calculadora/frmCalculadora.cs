namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        //declarando as variáveis globais
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
            //limpa os visores
            txtVisor.Text = "0";
            txtHistorico.Clear();

            //reseta as variáveis usadas no cálculo
            valorAnterior = 0;
            valorVisor = 0;

            //reseta as variáveis de controle
            operacao = "";
            primeiraOperacao = true;
            botaoIgual = false;
            podeApagar = false;
        }

        //ao clicar no botão de backSpace
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            //se o visor tiver apenas um caractere
            if (txtVisor.Text.Length == 1)
            {
                txtVisor.Text = "0"; //deixa o valor como: 0
            }
            else
            {
                //o mesmo que:
                //txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);
                //remove o último caractere presente no visor
                txtVisor.Text = txtVisor.Text[..^1];
            }
        }

        //ao clicar no botão de igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            //se já tiver dado um clique no botão igual ou não ter uma operação definida
            if (botaoIgual || string.IsNullOrEmpty(operacao))
            {
                return; //impede o fluxo do código
            }

            //se a operação for de raiz quadrada
            if (operacao == "\u221A")
            {
                //chama o método responsável pelo cálculo da raiz e guarda
                decimal resultado = EfetuaRaiz(txtVisor.Text);

                //exibe o resultado no historico e no visor principal
                txtHistorico.Text = txtVisor.Text + " = " + resultado;
                txtVisor.Text = resultado.ToString();

                //o valor anterior a ser usado agora é o resultado da raiz
                valorAnterior = resultado;

                //altera as variáveis de controle para a situação correspondente
                botaoIgual = true;
                podeApagar = true; //permite que o valor do visor seja substituido para efetuar a nova operação
                primeiraOperacao = false;
                operacao = "";

                return; //para o fluxo já que foi um cálculo diferente das 4 operações
            }

            //-------------- se for uma das 4 operações --------------

            //remove o operador que tiver no txtHistorico
            RemoveUltimoOperador();

            //converte o valor do visor para decimal e guarda na variável
            valorVisor = Convert.ToDecimal(txtVisor.Text);

            //exibe o novo texto do historico
            txtHistorico.Text += operacao + txtVisor.Text;

            //instância a classe criando um novo objeto
            ObjetoCalculo novoCalculo = new ObjetoCalculo();

            //atribui os valores das variáveis às propriedades do objeto
            novoCalculo.valorVisor = this.valorVisor;
            novoCalculo.valorAnterior = this.valorAnterior;
            novoCalculo.operacao = operacao;

            //chama o método Calculo atribuindo seu retorno ao txtVisor
            txtVisor.Text = Convert.ToString(novoCalculo.Calculo());

            //exibe o resultado que foi guardado no txtVisor
            txtHistorico.Text += " = " + txtVisor.Text;

            //o valor anterior a ser usado agora é o resultado presente no txtVisor
            valorAnterior = Convert.ToDecimal(txtVisor.Text);

            //altera as variáveis de controle
            botaoIgual = true;
            podeApagar = true;
            primeiraOperacao = false;
            operacao = "";
        }

        //método para remover o operador do txtHistorico
        private void RemoveUltimoOperador()
        {
            //um array com todos as 4 operações
            string[] operadores = [" + ", " - ", " x ", " ÷ "];

            //a variável op percorre toda essa array
            foreach (string op in operadores)
            {
                //se o txtHistorico termina com algum desses operadores
                if (txtHistorico.Text.EndsWith(op))
                {
                    txtHistorico.Text = txtHistorico.Text[..^3]; //apaga o operador e os espaços deixados
                    break; //impede "op" de continuar percorrendo o array, encerrando o método
                }
            }
        }

        //Adiciona valor ao clicar nos botões numéricos
        private void ClicouBotao_Click(object sender, EventArgs e)
        {

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

            //------- usando tags -------

            //se tiver o valor 0 no visor ou se for permitido substituir os números
            if (txtVisor.Text == "0" || podeApagar)
            {
                //apaga o txtVisor
                txtVisor.Clear();

                //reseta a variável permitindo que mais números sejam inseridos
                podeApagar = false; 
            }

            //sender: quem disparou o evento.
            //sender é do tipo Object então convertemos explicitamente para o tipo Button
            //criamos uma variável do mesmo tipo e guardamos as informações do sender nela
            //agora é possivel ter algumas informações sobre o botão que disparou o evento
            Button botaoClicado = (Button)sender;

            //armazena a tag desse botão na variável
            //como a tag também é um Object, é preciso converter para string
            string valorBotao = botaoClicado.Tag.ToString();

            //se o botão for uma vírgula
            if (valorBotao == ",")
            {
                //e se ainda não existe uma vírgula no txt
                if (!txtVisor.Text.Contains(","))
                {
                    if (string.IsNullOrEmpty(txtVisor.Text)) //se o visor tiver vazio adiciona 0 e depois a vírgula
                        txtVisor.Text = "0,";
                    else
                        txtVisor.Text += ","; //se tiver algo no visor adiciona somente a vírgula
                }
            }
            //se não for uma vírgula adiciona o número no visor
            else
            {
                txtVisor.Text += valorBotao;
            }
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


        //método que efetua as 4 operações
        public string Efetuacao(string operacao)
        {
            //caso seja a primeira operação
            if (primeiraOperacao)
            {
                //converte o primeiro valor para decimal
                valorAnterior = Convert.ToDecimal(txtVisor.Text);

                //se ainda não clicou no botão de igual
                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text + operacao; //exibe o primeiro valor e a operação correspondente
                }

                //limpa o visor
                txtVisor.Clear();

                //não é mais a primeira operação
                primeiraOperacao = false;
            }
            //caso outro clique seja feito e não é a primeira operação
            else
            {
                //remove o operado inserido antes no txtHistorico
                RemoveUltimoOperador();

                //exibe o novo historico
                txtHistorico.Text += operacao + txtVisor.Text;

                //converte o valor atual para decimal
                valorVisor = Convert.ToDecimal(txtVisor.Text);

                //instância a classe criando um novo objeto
                ObjetoCalculo novoCalculo = new ObjetoCalculo();

                //atribui os valores das variáveis às propriedades do objeto
                novoCalculo.valorVisor = this.valorVisor;
                novoCalculo.valorAnterior = this.valorAnterior;
                novoCalculo.operacao = operacao;

                //txtVisor.Text = Convert.ToString(Calculo(operacao)); << sem usar classe

                //chama o método Calculo atribuindo seu retorno ao txtVisor
                txtVisor.Text = Convert.ToString(novoCalculo.Calculo());

                //o valor anterior a ser usado agora é o resultado presente no txtVisor
                valorAnterior = Convert.ToDecimal(txtVisor.Text);

                //exibe o resultado no historico
                txtHistorico.Text += " = " + txtVisor.Text;
                
                //altera a variável de controle
                podeApagar = true;
            }

            return operacao; //retorna o valor da operação
        }

        //método que interpreta a raiz
        private decimal EfetuaRaiz(string texto)
        {
            //Split: corta uma string em pedaços usando um separador retornando um array
            //o separador usado é a raiz quadrada em unicode
            string[] partes = texto.Split("\u221A");

            /* - EXEMPLO DE USO -
             * se não tiver multiplicador:
                string texto = "√9";
                string[] partes = texto.Split("√");

                partes[0] = ""     // antes do √
                partes[1] = "9"    // depois do √

             * se tiver multiplicador:
                string texto = "2√5";
                string[] partes = texto.Split("√");

                partes[0] = "2"     // antes do √
                partes[1] = "5"     // depois do √
             */

            //define as variáveis que vão armazenar o multiplicador e o radical
            decimal multiplicador;
            decimal radical;

            //se não tiver multiplicador, assume 1
            //se tiver converte para decimal
            multiplicador = string.IsNullOrEmpty(partes[0]) ? 1 : Convert.ToDecimal(partes[0]);

            //radical está sempre na segunda parte, assim como demonstra o exemplo
            radical = Convert.ToDecimal(partes[1]);         

            //com a raiz interpretada corretamente
            //podemos chamar o objeto de calculo para a raiz
            ObjetoCalculo calculo = new ObjetoCalculo
            {
                valorVisor = radical,
                operacao = "\u221A",
            };

            //calcula a raiz e multiplica pelo multiplicador
            decimal resultado = multiplicador * calculo.Calculo();

            //retorna o valor arredondado em duas casas decimais
            return Math.Round(resultado, 2);               
        }

        //ao clicar nos botões de operação
        //chama o método de cálculo e atribui seu retorno a variável: operacao
        private void btnAdicao_Click(object sender, EventArgs e) => operacao = Efetuacao(" + ");
        private void btnSubtracao_Click(object sender, EventArgs e) => operacao = Efetuacao(" - ");
        private void btnMultiplicacao_Click(object sender, EventArgs e) => operacao = Efetuacao(" x ");
        private void btnDivisao_Click(object sender, EventArgs e) => operacao = Efetuacao(" ÷ ");

        //o botão de raiz quadrada necessita de uma lógica adicional
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            //altera as variáveis de controle
            operacao = "\u221A";
            botaoIgual = false;

            //se o txt tiver vazio ou com as variáveis de controle que impedem de certa forma adicionar caracteres
            if (txtVisor.Text == "0" || botaoIgual || podeApagar)
            {
                //apaga o conteúdo e exibe o símbolo da raiz
                txtVisor.Clear();
                txtVisor.Text = operacao;

                //altera as variáveis de controle para permitir a inserção de mais digitos
                botaoIgual = false;
                podeApagar = false;
            }
            //se tiver números no txt e não existir o símbolo de raiz
            else if (!txtVisor.Text.Contains(operacao))
            {
                txtVisor.Text += operacao; //adiciona o símbolo
            }
        }
    }
}
