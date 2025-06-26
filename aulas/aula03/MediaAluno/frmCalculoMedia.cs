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

            nota1 = Convert.ToDouble(txtNota1.Text) * Convert.ToDouble(cboPesoNota1.Text);
            nota2 = double.Parse(txtNota2.Text) * double.Parse(cboPesoNota2.Text);
            notaTrabalho = Convert.ToDouble(txtTrabalho.Text) * Convert.ToDouble(cboPesoTrabalho.Text);

            double media = nota1 + nota2 + notaTrabalho;

            txtMediaFinal.Text = media.ToString();

            double quantFalta, quantAula;

            quantFalta = Convert.ToDouble(txtQdeFaltas.Text);
            quantAula = Convert.ToDouble(txtQdeAulas.Text);

            //calcula a porcentagem de falta e logo após subtrai 100 obtendo a porcentagem de presenca
            double porcentagemPresenca = 100 - ((quantFalta / quantAula) * 100);

            //transforma a media em porcentagem e soma com a presenca
            //dividi por dois para obter uma media em porcentagem do aproveitamento
            double porcentagemAproveitamento = ((media * 10) + porcentagemPresenca) / 2;

            txtAproveitamento.Text = porcentagemAproveitamento + "%";

        }
    }
}
