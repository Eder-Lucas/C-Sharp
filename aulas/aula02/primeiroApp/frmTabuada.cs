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
            txtTabuada.ReadOnly = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTabuada.Text = "";

            if (txtNumero.Text == "")
            {
                MessageBox.Show("Você precisa digitar um número para gerar a tabuada",
                                 "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double numero, resultado;
                numero = double.Parse(txtNumero.Text);

                for (int i = 1; i <= 10; i++)
                {
                    resultado = numero * i;
                    txtTabuada.Text += numero + "x" + i + "=" + resultado + "\r\n";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtTabuada.Text = "";
        }
    }
}
