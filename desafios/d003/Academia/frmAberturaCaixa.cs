using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmAberturaCaixa : Form
    {
        public frmAberturaCaixa()
        {
            InitializeComponent();
        }

        private void frmAberturaCaixa_Load(object sender, EventArgs e)
        {
            string data = DateTime.Today.Date.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();

            this.Text = $"Abertura do Caixa - Data: {data} - Hora: {hora}";
        }

        private void cboValorInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboValorInicial.Text == "Zerado")
            {
                tcCaixa.Enabled = false;
                txtDinheiro.Text = "0,00";
                txtCaixa.Text = "0,00";
            }
            if (cboValorInicial.Text == "Com os valores que eu digitar")
            {
                tcCaixa.Enabled = true;
                txtDinheiro.Text = "0,00";
                txtCaixa.Text = "0,00";
                txtDinheiro.Focus();
            }
        }
    }
}
