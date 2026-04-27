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

        private Caixa novoCaixa;

        public decimal ValorAbertura { get; private set; }

        private void frmAberturaCaixa_Load(object sender, EventArgs e)
        {
            string data = DateTime.Today.Date.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();

            this.Text = $"Abertura do Caixa - Data: {data} - Hora: {hora}";
        }

        private void switchZerado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                switchSaldoAnterior.Checked = false;
        }

        private void switchSaldoAnterior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                switchZerado.Checked = false;
        }

        private void btnCancelarAbertura_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                if (switchZerado.Checked && txtTotal.Text == "0,00")
                {
                    IniciaZerado();
                }
                else
                {
                    decimal valorAbertura = Convert.ToDecimal(txtValorAbertura.Text);
                    decimal total = Convert.ToDecimal(txtTotal.Text) + valorAbertura;
                    novoCaixa = new Caixa();

                    novoCaixa.Salvar(DateTime.Today, DateTime.Now, total, true);

                    DataTable dadosCaixa = novoCaixa.Listar();
                    ValorAbertura = Convert.ToDecimal(dadosCaixa.Rows[0]["SALDO_INICIAL"]);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void switchZerado_OnCheckedChanged(object sender, EventArgs e)
        {
            if (switchZerado.Checked)
            {
                txtTotal.Enabled = false;
                txtSaldoAnterior.Enabled = false;
                txtValorAbertura.Enabled = false;
            }
            else
            {
                txtSaldoAnterior.Enabled = true;
                txtTotal.Enabled = true;
                txtValorAbertura.Enabled = true;

            }
        }

        private void switchSaldoAnterior_CheckedChanged(object sender, EventArgs e)
        {
            if (switchSaldoAnterior.Checked)
            {
                txtSaldoAnterior.Enabled = false;
            }
            else
            {
                txtSaldoAnterior.Enabled = true;
            }
        }

        private void IniciaZerado()
        {
            txtTotal.Text = "0,00";
            txtSaldoAnterior.Text = "0,00";
            txtValorAbertura.Text = "0,00";

            novoCaixa = new Caixa();

            novoCaixa.Salvar(DateTime.Today, DateTime.Now, Convert.ToDecimal(txtTotal.Text), true);

            DataTable dadosCaixa = novoCaixa.Listar();
            ValorAbertura = Convert.ToDecimal(dadosCaixa.Rows[0]["SALDO_INICIAL"]);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
