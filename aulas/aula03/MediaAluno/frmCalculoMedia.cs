namespace MediaAluno
{
    public partial class frmCalculoMedia : Form
    {
        public frmCalculoMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, notaTrabalho;
            double peso1, peso2, pesoTrabalho;

            peso1 = Convert.ToDouble(cboPesoNota1.Text);
            peso2 = Convert.ToDouble(cboPesoNota2.Text);
            pesoTrabalho = Convert.ToDouble(cboPesoTrabalho.Text);

            nota1 = Convert.ToDouble(txtNota1.Text) * peso1;
            nota2 = double.Parse(txtNota2.Text) * peso2;
            notaTrabalho = Convert.ToDouble(txtTrabalho.Text) * pesoTrabalho;

            double media = (nota1 + nota2 + notaTrabalho) / (peso1 + peso2 + pesoTrabalho);

            txtMediaFinal.Text = media.ToString();

            double quantFalta, quantAula;

            quantFalta = Convert.ToDouble(txtQdeFaltas.Text);
            quantAula = Convert.ToDouble(txtQdeAulas.Text);

            //calcula a porcentagem de falta e logo após subtrai 100 obtendo a porcentagem de presenca
            double porcentagemFrequencia = 100 - ((quantFalta / quantAula) * 100);

            //transforma a media em porcentagem e soma com a presenca
            //dividi por dois para obter uma media em porcentagem do aproveitamento
            double porcentagemAproveitamento = ((media * 10) + porcentagemFrequencia) / 2;

            txtAproveitamento.Text = porcentagemAproveitamento.ToString("F2") + "%";

            if (txtRecuperacao.Text == "")
            {
                if (media >= Convert.ToDouble(numNotaCorte.Value) && porcentagemFrequencia >= 75)
                {
                    lblSituacao.Text = "Aprovado";
                    lblSituacao.ForeColor = Color.Green;
                }
                else if (media <= 2.5 || porcentagemFrequencia <= 75)
                {
                    lblSituacao.Text = "Reprovado";
                    lblSituacao.ForeColor = Color.Firebrick;
                }
                else
                {
                    lblSituacao.Text = "Recuperação";
                    lblSituacao.ForeColor = Color.Firebrick;
                }
            }
            else
            {
                media = (media + Convert.ToDouble(txtRecuperacao.Text)) / 2;

                porcentagemAproveitamento = ((media * 10) + porcentagemFrequencia) / 2;
                txtAproveitamento.Text = porcentagemAproveitamento.ToString("F2") + "%";

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
            txtMediaFinal.Text = media.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblSituacao.Text = "";
            txtRecuperacao.Text = string.Empty;

            foreach(Control Componente in this.Controls)
            {
                if(Componente is TextBox txt)
                {
                    txt.Clear();
                }

                else if(Componente is ComboBox cbo)
                {
                    cbo.SelectedIndex = -1;
                }

                else if(Componente is NumericUpDown num)
                {
                    num.Value = 5;
                }
            }
        }
    }
}
