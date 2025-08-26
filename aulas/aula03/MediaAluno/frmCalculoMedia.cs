namespace MediaAluno
{
    public partial class frmCalculoMedia : Form
    {
        public frmCalculoMedia()
        {
            InitializeComponent();
        }

        //Quando clicar no botão de calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //definindo as variaveis de peso
            double peso1, peso2, pesoTrabalho;

            //atribuindo e convertendo para double seus respectivos valores
            peso1 = Convert.ToDouble(cboPesoNota1.Text);
            peso2 = Convert.ToDouble(cboPesoNota2.Text);
            pesoTrabalho = Convert.ToDouble(cboPesoTrabalho.Text);

            //definindo as variaveis de nota
            double nota1, nota2, notaTrabalho;

            //o calculo da média será ponderado
            //atribuindo valores as variaveis de nota e já multiplicando pelo peso
            nota1 = Convert.ToDouble(txtNota1.Text) * peso1;
            nota2 = double.Parse(txtNota2.Text) * peso2;
            notaTrabalho = Convert.ToDouble(txtTrabalho.Text) * pesoTrabalho;

            //efetuando a última parte do cálculo da média ponderada
            double media = (nota1 + nota2 + notaTrabalho) / (peso1 + peso2 + pesoTrabalho);
            txtMediaFinal.Text = media.ToString("F2"); //mostra a média no txt com só duas casas decimais

            //definindo e atribuindo valor as variaveis de quantidade de falta e aula
            double quantFalta, totalAula;
            quantFalta = Convert.ToDouble(txtQdeFaltas.Text);
            totalAula = Convert.ToDouble(txtQdeAulas.Text);

            /*
            calcula a porcentagem de falta por uma regra de 3 simplificada e subtrai de 100 para obter a frequência:

                totalAulas -- 100   e depois 100 - x
                quantFalta --  x

            mesmo que: 
                100 - (quantFalta * 100) / totalAulas OU 100 - (quantFalta / totalAula) * 100    
             */
            double porcentagemFrequencia = 100 - ((quantFalta / totalAula) * 100);

            //o cálculo de aproveitamento é uma média entre a frequência e a media final do aluno
            //multiplico a média por 10 para ficar em porcentagem e divido por 2 obtendo a média de aproveitamento
            double porcentagemAproveitamento = ((media * 10) + porcentagemFrequencia) / 2;

            //exibindo o aproveitamento no txt
            //.ToString("F2") permite apenas duas casas após a vírgula
            txtAproveitamento.Text = porcentagemAproveitamento.ToString("F2") + "%";

            //Se não tiver em recuperação
            if (txtRecuperacao.Text == "")
            {
                //verifica se a média é maior que a nota de corte e se a frequência é maior que 75%
                if (media >= Convert.ToDouble(numNotaCorte.Value) && porcentagemFrequencia >= 75)
                {
                    lblSituacao.Text = "Aprovado"; //se for verdade o aluno é aprovado
                    lblSituacao.ForeColor = Color.Green;
                }
                //se não, verifica se a média é menor que 2.5(25%) e frequência menor que 75%
                else if (media <= 2.5 || porcentagemFrequencia <= 75)
                {
                    lblSituacao.Text = "Reprovado"; //se verdade o aluno é reprovado
                    lblSituacao.ForeColor = Color.Firebrick;
                }
                //caso nenhum for verdade o aluno está em recuperação
                else
                {
                    lblSituacao.Text = "Recuperação";
                    lblSituacao.ForeColor = Color.Firebrick;
                }
            }
            //caso o aluno esteja em recuperação
            else
            {
                //cálcula sua nova media somando com a nota da recuperação
                media = (media + Convert.ToDouble(txtRecuperacao.Text)) / 2;
                txtMediaFinal.Text = media.ToString("F2");

                //seu aproveitamento também é cálculado novamente já que a media foi alterada
                porcentagemAproveitamento = ((media * 10) + porcentagemFrequencia) / 2;
                txtAproveitamento.Text = porcentagemAproveitamento.ToString("F2") + "%";

                //verifica sua aprovação
                if (media >= Convert.ToDouble(numNotaCorte.Value))
                {
                    lblSituacao.Text = "Aprovado";
                    lblSituacao.ForeColor = Color.Green;
                }
                else
                {
                    lblSituacao.Text = "Reprovado";
                    lblSituacao.ForeColor = Color.Firebrick;
                }
            }

        }

        //quando clica no botão de limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //apagando o caractere desse label em especifico
            lblSituacao.Text = string.Empty;

            //usando o foreach para apagar os conteúdos 
            //Control Componente: é a variável que representa o item atual da coleção a cada iteração.
            //this.Controls: se refere a todos os componentes do form
            foreach (Control Componente in this.Controls)
            {
                //se o componente que estiver sendo verificado for um TextBox, armazena na variavel 'txt'
                if(Componente is TextBox txt) 
                {
                    txt.Clear(); //o conteúdo é apagado
                }

                else if(Componente is ComboBox cbo)
                {
                    cbo.SelectedIndex = -1; //seleciona nenhum item da lista, deixando ele vazio
                }

                else if(Componente is NumericUpDown num)
                {
                    num.Value = 5; //formata para o valor 5
                }
            }
        }
    }
}
