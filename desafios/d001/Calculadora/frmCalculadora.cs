namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void ClicouBotao_Click(object sender, EventArgs e)
        {
            //txtVisor.Text += "1";      

            if (txtVisor.Text == "0")
            {
                txtVisor.Clear();
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
    }
}
