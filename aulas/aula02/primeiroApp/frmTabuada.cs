using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroApp
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
            txtTabuada.ReadOnly = true; //Não permite digitar no campo de tabuada
        }

        //Quando clicar no botão de calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTabuada.Text = ""; //Limpa a tabuada

            if (txtNumero.Text == "") //Se não tiver número uma mensagem é exibida
            {
                MessageBox.Show("Você precisa digitar um número para gerar a tabuada",
                                 "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //Se tiver um número o calculo é efetuado
            {
                double numero, resultado; //Permite números decimais
                numero = double.Parse(txtNumero.Text); //Convertendo o número inserido em Number

                //Loop for 
                for (int i = 1; i <= 10; i++)
                {
                    resultado = numero * i; //Vai multiplicando até chegar em 10
                    txtTabuada.Text += numero + "x" + i + "=" + resultado + "\r\n"; //Exibe no TextBox de forma organizada
                }
            }
        }

        //Quando clicar no botão limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Todo conteúdo é apagado
            txtNumero.Text = "";
            txtTabuada.Text = "";
        }
    }
}
