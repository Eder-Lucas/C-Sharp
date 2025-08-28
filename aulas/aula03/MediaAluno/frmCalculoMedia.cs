namespace MediaAluno
{
    public partial class frmCalculoMedia : Form
    {
        public frmCalculoMedia()
        {
            InitializeComponent();
            mouseCursor(); //fun��o que trata do cursor do mouse

            Recuperacao = false; //inicia o app com o aluno fora da recupera��o, travando o txt
        }

        //controlando o estado de recupera��o
        private bool _recuperacao; //� como a "caixinha" onde o valor fica guardado
        public bool Recuperacao //� a "porta" que usa para colocar ou pegar esse valor
        {
            //grava esse valor - true ou false - no campo _recuperacao e atualiza a interface
            set
            {
                _recuperacao = value;

                //se Recuperacao = true, o operador '!' inverte o valor para false
                //permitindo que o usu�rio insira uma nota de recupera��o
                txtRecuperacao.ReadOnly = !_recuperacao;
            }
            //devolve o valor que est� guardado no campo _recuperacao
            get
            {
                return _recuperacao;
            }
        }

        //Quando clicar no bot�o de calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!Validacao(this))
            {
                return;
            }

            //definindo as variaveis de nota
            double notaTxt_1, notaTxt_2, notaTrabalho_txt;

            notaTxt_1 = Convert.ToDouble(txtNota1.Text);
            notaTxt_2 = double.Parse(txtNota2.Text);
            notaTrabalho_txt = Convert.ToDouble(txtTrabalho.Text);

            //definindo as variaveis de peso
            double peso1, peso2, pesoTrabalho;

            //atribuindo e convertendo para double seus respectivos valores
            peso1 = Convert.ToDouble(cboPesoNota1.Text);
            peso2 = Convert.ToDouble(cboPesoNota2.Text);
            pesoTrabalho = Convert.ToDouble(cboPesoTrabalho.Text);



            //o calculo da m�dia ser� ponderado
            //atribuindo valores as variaveis de nota e j� multiplicando pelo peso
            double nota1, nota2, notaTrabalho;
            nota1 =  notaTxt_1 * peso1;
            nota2 = notaTxt_2 * peso2;
            notaTrabalho = notaTrabalho_txt * pesoTrabalho;

            //efetuando a �ltima parte do c�lculo da m�dia ponderada
            double media = (nota1 + nota2 + notaTrabalho) / (peso1 + peso2 + pesoTrabalho);

            //definindo e atribuindo valor as variaveis de quantidade de falta e aula
            double quantFalta, totalAula;
            quantFalta = Convert.ToDouble(txtQdeFaltas.Text);
            totalAula = Convert.ToDouble(txtQdeAulas.Text);

            /*
            calcula a porcentagem de falta por uma regra de 3 simplificada e subtrai de 100 para obter a frequ�ncia:

                totalAulas -- 100   e depois 100 - x
                quantFalta --  x

            mesmo que: 
                100 - (quantFalta * 100) / totalAulas OU 100 - (quantFalta / totalAula) * 100    
             */
            double porcentagemFrequencia = 100 - ((quantFalta / totalAula) * 100);

            //o c�lculo de aproveitamento � uma m�dia entre a frequ�ncia e a media final do aluno
            //multiplico a m�dia por 10 para ficar em porcentagem e divido por 2 obtendo a m�dia de aproveitamento
            double porcentagemAproveitamento = ((media * 10) + porcentagemFrequencia) / 2;

            //exibindo o aproveitamento e media no txt
            //.ToString("F2") permite apenas duas casas ap�s a v�rgula
            txtAproveitamento.Text = porcentagemAproveitamento.ToString("F2") + "%";
            txtMediaFinal.Text = media.ToString("F2");

            //Se n�o tiver em recupera��o
            if (txtRecuperacao.Text == "")
            {
                //verifica se a m�dia � maior que a nota de corte e se a frequ�ncia � maior que 75%
                if (media >= Convert.ToDouble(numNotaCorte.Value) && porcentagemFrequencia >= 75)
                {
                    lblSituacao.Text = "Aprovado"; //se for verdade o aluno � aprovado
                    lblSituacao.ForeColor = Color.Green;
                }
                //se n�o, verifica se a m�dia � menor que 2.5(25%) e frequ�ncia menor que 75%
                else if (media <= 2.5 || porcentagemFrequencia <= 75)
                {
                    lblSituacao.Text = "Reprovado"; //se verdade o aluno � reprovado
                    lblSituacao.ForeColor = Color.Firebrick;
                }
                //caso nenhum for verdade o aluno est� em recupera��o
                else
                {
                    Recuperacao = true; //aluno em recupera��o
                    lblSituacao.Text = "Recupera��o";
                    lblSituacao.ForeColor = Color.Firebrick;
                }
            }
            //caso o aluno esteja em recupera��o
            else
            {
                //c�lcula sua nova media somando com a nota da recupera��o
                media = (media + Convert.ToDouble(txtRecuperacao.Text)) / 2;
                txtMediaFinal.Text = media.ToString("F2");

                //seu aproveitamento tamb�m � c�lculado novamente j� que a media foi alterada
                porcentagemAproveitamento = ((media * 10) + porcentagemFrequencia) / 2;
                txtAproveitamento.Text = porcentagemAproveitamento.ToString("F2") + "%";

                //verifica sua aprova��o
                if (media >= Convert.ToDouble(numNotaCorte.Value))
                {
                    Recuperacao = false; //aluno sai a recupera��o
                    lblSituacao.Text = "Aprovado";
                    lblSituacao.ForeColor = Color.Green;
                }
                else
                {
                    Recuperacao = false; //encerra a recupera��o, o aluno foi reprovado
                    lblSituacao.Text = "Reprovado";
                    lblSituacao.ForeColor = Color.Firebrick;
                }
            }

        }

        //quando clica no bot�o de limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //reseta o estado de recuperacao
            Recuperacao = false;
            txtRecuperacao.Text = "";

            //apagando o caractere desse label em especifico
            lblSituacao.Text = string.Empty;

            //usando o foreach para apagar os conte�dos 
            //Control Componente: � a vari�vel que representa o item atual da cole��o a cada itera��o.
            //this.Controls: se refere a todos os componentes do form
            foreach (Control Componente in this.Controls)
            {
                //se o componente que estiver sendo verificado for um TextBox, armazena na variavel 'txt'
                if (Componente is TextBox txt)
                {
                    txt.Clear(); //o conte�do � apagado
                }

                else if (Componente is ComboBox cbo)
                {
                    cbo.SelectedIndex = -1; //seleciona nenhum item da lista, deixando ele vazio
                }

                else if (Componente is NumericUpDown num)
                {
                    num.Value = 5; //formata para o valor 5
                }
            }
        }

        //fun��o para tratar do cursor
        private void mouseCursor()
        {
            //itera todo os controles do form
            foreach (Control c in this.Controls)
            {
                //se for um bot�o ou comboBox
                if (c is Button || c is ComboBox)
                {
                    //aplica os evento
                    c.MouseEnter += (s, e) => Cursor = Cursors.Hand;
                    c.MouseLeave += (s, e) => Cursor = Cursors.Default;
                    /*
                     forma simplificada de:
                        private void c_MouseEnter(object sender, EventArgs e)
                        {
                            Cursor = Cursors.Hand;
                        }
                     */
                }
            }
        }

        private ErrorProvider errorProvider = new ErrorProvider();
        private bool Validacao(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt && !txt.ReadOnly)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        ExibirErro(c, "Impossivel realizar o c�lculo pois h� campos vazios.", "Insira um valor!");
                        return false;
                    }

                    if (!double.TryParse(txt.Text, out _))
                    {
                        ExibirErro(c, "Impossivel realizar o c�lculo. Use apenas n�meros.", "Insira um n�mero!");
                        return false;
                    }
                }
                else if (c is ComboBox cbo && cbo.SelectedIndex == -1)
                {
                    ExibirErro(c, "Impossivel realizar o c�lculo, informe o valor dos pesos.", "Selecione uma op��o!");
                        return false;
                }
                else if (c.HasChildren && !Validacao(c))
                {
                    return false;
                }
                errorProvider.SetError(c, "");
            }
        return true;
        }

        private bool ExibirErro(Control c, string mensagem, string erro)
        {
            MessageBox.Show(mensagem,
                                "Erro ao gerar a m�dia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
            );

            errorProvider.SetError(c, erro);
            c.Focus();
            return false;
        }
    }
}
