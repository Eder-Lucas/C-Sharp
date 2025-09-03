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
            this.Load += FormPrincipal_Load; //conecta o evento Load ao formulário
        }

        //load é disparado quando o formulário está prestes a ser exibido pela primeira vez
        //tornando ótimo para ligar eventos e definir alguns parâmetros
        private void FormPrincipal_Load(object? sender, EventArgs? e)//'?' indica que o pode ser nulo.
        {
            //conecta os eventos radioButtons a função 
            //CheckedChanged => dispara sempre que o valor de Checked muda
            rbCelsius1.CheckedChanged += AtualizarRadioButtons;
            rbFahrenheit1.CheckedChanged += AtualizarRadioButtons;
            rbKelvin1.CheckedChanged += AtualizarRadioButtons;

            //chamando a função que trata do cursor
            MouseCursor(this); //passa o formulário como primeiro argumento
        }

        //variavel de escopo global que armazena a unidade( Celsius, Kelvin, Fahrenheit )
        string unidade = "";

        //Função que atualiza os radioButtons dependendo de qual foi selecionado
        private void AtualizarRadioButtons(object? sender, EventArgs? e)
        {
            //inicializa todos como habilitado
            rbCelsius2.Enabled = true;
            rbFahrenheit2.Enabled = true;
            rbKelvin2.Enabled = true;

            //se o usuário marcar o mesmo radioButton como entrada e saída
            //a unidade de saída correspondente é desabilitada
            //evita erro na conversão
            if (rbCelsius1.Checked) rbCelsius2.Enabled = false;
            if (rbFahrenheit1.Checked) rbFahrenheit2.Enabled = false;
            if (rbKelvin1.Checked) rbKelvin2.Enabled = false;
        }

        //objeto usado para tratar erros visualmente
        private ErrorProvider errorProvider = new ErrorProvider();

        //evento ao clicar no botão converter
        private void buttonConverter_Click(object sender, EventArgs e)
        {
            //tentar converter uma string em um número do tipo double. Retornando true se conseguir
            //como foi comparado com 'false', retornará true se NÃO conseguir converter
            //ou seja, o que foi digitado não foi um valor númerico logo não pode ser convertido pra double
            if (double.TryParse(txtValor.Text, out _) == false)
            {
                errorProvider.SetError(txtValor, "Adicione um valor");
                return; //retorna a função impedindo a conversão
            }
            //se o valor passar na validação

            //remove o erro
            errorProvider.SetError(txtValor, "");

            //criando as variaveis necessárias
            double valor = Convert.ToDouble(txtValor.Text);
            double resultado = valor;

            //se o campo Celsius for marcado
            if (rbCelsius1.Checked)
            {
                //atribui a unidade de Celsius
                //importante caso uma opção de saída não seja marcada
                unidade = "°C"; 

                //realiza a conversão se algum dos outros campos possiveis forem marcados
                if (rbKelvin2.Checked) 
                {
                    resultado = (valor + 273);
                    unidade = "K"; //atribui sua respectiva unidade
                }
                else if (rbFahrenheit2.Checked)
                {
                    resultado = (valor * 1.8 + 32);
                    unidade = "°F";
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
                    unidade = "°C";
                }
                else if (rbFahrenheit2.Checked)
                {
                    resultado = (valor * 1.8 - 459.67);
                    unidade = "°F";
                }
            }

            //se o campo Fahrenheit for marcado
            else if (rbFahrenheit1.Checked)
            {
                //atribui sua respectiva unidade
                unidade = "°F";

                if (rbCelsius2.Checked)
                {
                    resultado = ((valor - 32) / 1.8);
                    unidade = "°C";
                }
                else if (rbKelvin2.Checked)
                {
                    resultado = ((valor + 459.67) / 1.8);
                    unidade = "K";
                }
            }

            //usando operador ternário para validar o resultado
            txtResultado.Text = resultado % 1 == 0 //se for inteiro
                ? ((int)resultado).ToString() + unidade //transforma em tipo inteiro e passa para string
                : resultado.ToString("F2") + unidade; //se não for é mostrado com duas casas decimais
        }

        //ao clicar no botão limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //this representa o próprio formulário, ou seja, o container principal
            //Então o método vai começar a percorrer todos os controles dentro do formulário
            LimpaControles(this);     
        }

        //função que limpa todos os controles do formulário
        private void LimpaControles(Control parent) //recebe um controle que pode conter "Filhos"
        {
            //percorre cada controle filho do parent armazenando em 'c' a cada loop
            foreach (Control c in parent.Controls)
            {
                //verificação com switch case para cada tipo de controle
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
                //chama a função novamente passando esse controle como parâmetro
                //esse método é chamado de função recursiva
                if (c.HasChildren) LimpaControles(c);
            }
        }

        //função para alterar o cursor do mouse
        private void MouseCursor(Control parent) //recebe um controle, iniciando com o próprio formulário
        {
            foreach (Control c in parent.Controls) //percorre cada elemento desse controle
            {
                //verifica se é um botão ou radioButton
                //se for, aplica os eventos de mouse junto com o tratamento do mouse
                if (c is Button || c is RadioButton)
                {
                    c.MouseEnter += (s, e) => Cursor = Cursors.Hand;
                    c.MouseLeave += (s, e) => Cursor = Cursors.Default;
                }

                //caso o elemento tenha filhos
                //ele é passado novamente como parâmetro da função para ser analisado
                if (c.HasChildren) MouseCursor(c);
            }
        }
    }
}
