using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace conversorDeTemperatura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.Load += FormPrincipal_Load; //conecta o evento Load ao formul�rio
        }

        //load � disparado quando o formul�rio est� prestes a ser exibido pela primeira vez
        //tornando �timo para ligar eventos e definir alguns par�metros
        private void FormPrincipal_Load(object? sender, EventArgs? e)//'?' indica que o pode ser nulo.
        {
            //conecta os eventos radioButtons a fun��o 
            //CheckedChanged => dispara sempre que o valor de Checked muda
            rbCelsius1.CheckedChanged += AtualizarRadioButtons;
            rbFahrenheit1.CheckedChanged += AtualizarRadioButtons;
            rbKelvin1.CheckedChanged += AtualizarRadioButtons;

            //chamando a fun��o que trata do cursor
            MouseCursor(this); //passa o formul�rio como primeiro argumento
        }

        //variavel de escopo global que armazena a unidade( Celsius, Kelvin, Fahrenheit )
        string unidade = "";

        //Fun��o que atualiza os radioButtons dependendo de qual foi selecionado
        private void AtualizarRadioButtons(object? sender, EventArgs? e)
        {
            //inicializa todos como habilitado
            rbCelsius2.Enabled = true;
            rbFahrenheit2.Enabled = true;
            rbKelvin2.Enabled = true;

            //se o usu�rio marcar o mesmo radioButton como entrada e sa�da
            //a unidade de sa�da correspondente � desabilitada
            //evita erro na convers�o
            if (rbCelsius1.Checked) rbCelsius2.Enabled = false;
            if (rbFahrenheit1.Checked) rbFahrenheit2.Enabled = false;
            if (rbKelvin1.Checked) rbKelvin2.Enabled = false;
        }

        //objeto usado para tratar erros visualmente
        private ErrorProvider errorProvider = new ErrorProvider();

        //evento ao clicar no bot�o converter
        private void buttonConverter_Click(object sender, EventArgs e)
        {
            //tentar converter uma string em um n�mero do tipo double. Retornando true se conseguir
            //como foi comparado com 'false', retornar� true se N�O conseguir converter
            //ou seja, o que foi digitado n�o foi um valor n�merico logo n�o pode ser convertido pra double
            if (double.TryParse(txtValor.Text, out _) == false)
            {
                errorProvider.SetError(txtValor, "Adicione um valor");
                return; //retorna a fun��o impedindo a convers�o
            }
            //se o valor passar na valida��o

            //remove o erro
            errorProvider.SetError(txtValor, "");

            //criando as variaveis necess�rias
            double valor = Convert.ToDouble(txtValor.Text);
            double resultado = valor;

            //se o campo Celsius for marcado
            if (rbCelsius1.Checked)
            {
                //atribui a unidade de Celsius
                //importante caso uma op��o de sa�da n�o seja marcada
                unidade = "�C"; 

                //realiza a convers�o se algum dos outros campos possiveis forem marcados
                if (rbKelvin2.Checked) 
                {
                    resultado = (valor + 273);
                    unidade = "K"; //atribui sua respectiva unidade
                }
                else if (rbFahrenheit2.Checked)
                {
                    resultado = (valor * 1.8 + 32);
                    unidade = "�F";
                }
            }

            //se o campo Kelvin for marcado
            else if (rbKelvin1.Checked)
            {
                //atribui sua respectiva unidade
                unidade = "K";

                if (rbCelsius2.Checked)
                {
                    resultado = (valor - 273);
                    unidade = "�C";
                }
                else if (rbFahrenheit2.Checked)
                {
                    resultado = (valor * 1.8 - 459.67);
                    unidade = "�F";
                }
            }

            //se o campo Fahrenheit for marcado
            else if (rbFahrenheit1.Checked)
            {
                //atribui sua respectiva unidade
                unidade = "�F";

                if (rbCelsius2.Checked)
                {
                    resultado = ((valor - 32) / 1.8);
                    unidade = "�C";
                }
                else if (rbKelvin2.Checked)
                {
                    resultado = ((valor + 459.67) / 1.8);
                    unidade = "K";
                }
            }

            //usando operador tern�rio para validar o resultado
            txtResultado.Text = resultado % 1 == 0 //se for inteiro
                ? ((int)resultado).ToString() + unidade //transforma em tipo inteiro e passa para string
                : resultado.ToString("F2") + unidade; //se n�o for � mostrado com duas casas decimais
        }

        //ao clicar no bot�o limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //this representa o pr�prio formul�rio, ou seja, o container principal
            //Ent�o o m�todo vai come�ar a percorrer todos os controles dentro do formul�rio
            LimpaControles(this);     
        }

        //fun��o que limpa todos os controles do formul�rio
        private void LimpaControles(Control parent) //recebe um controle que pode conter "Filhos"
        {
            //percorre cada controle filho do parent armazenando em 'c' a cada loop
            foreach (Control c in parent.Controls)
            {
                //verifica��o com switch case para cada tipo de controle
                switch(c)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case RadioButton rb:
                        rb.Checked = false;
                        break;
                }

                //se o controle tiver outros controles dentro (Panel, GrupoBox e etc)
                //chama a fun��o novamente passando esse controle como par�metro
                //esse m�todo � chamado de fun��o recursiva
                if (c.HasChildren) LimpaControles(c);
            }
        }

        //fun��o para alterar o cursor do mouse
        private void MouseCursor(Control parent) //recebe um controle, iniciando com o pr�prio formul�rio
        {
            foreach (Control c in parent.Controls) //percorre cada elemento desse controle
            {
                //verifica se � um bot�o ou radioButton
                //se for, aplica os eventos de mouse junto com o tratamento do mouse
                if (c is Button || c is RadioButton)
                {
                    c.MouseEnter += (s, e) => Cursor = Cursors.Hand;
                    c.MouseLeave += (s, e) => Cursor = Cursors.Default;
                }

                //caso o elemento tenha filhos
                //ele � passado novamente como par�metro da fun��o para ser analisado
                if (c.HasChildren) MouseCursor(c);
            }
        }
    }
}
