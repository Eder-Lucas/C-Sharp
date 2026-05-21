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
                else if (switchSaldoAnterior.Checked)
                {
                    IniciaSaldoAnterior();
                }
                else
                {
                    decimal valorAbertura = Convert.ToDecimal(txtValorAbertura.Text);

                    MessageBox.Show($"Valor de abertura: {valorAbertura:C2}", "Valor de Abertura", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    novoCaixa = new Caixa();

                    int IdCaixa = novoCaixa.Salvar(DateTime.Today, DateTime.Now, valorAbertura, true);
                    Caixa.AtualizarCaixa(IdCaixa);

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

                txtTotal.Text = "0,00";
                txtSaldoAnterior.Text = "0,00";
                txtValorAbertura.Text = "0,00";

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
            try
            {
                if (switchSaldoAnterior.Checked)
                {
                    novoCaixa = new Caixa();
                    txtSaldoAnterior.Enabled = false;
                    decimal saldoAnterior = novoCaixa.SaldoAnterior();
                    txtSaldoAnterior.Text = saldoAnterior.ToString();
                }
                else
                {
                    txtSaldoAnterior.Enabled = true;
                    txtSaldoAnterior.Text = "0,00";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void IniciaZerado()
        {
            txtTotal.Text = "0,00";
            txtSaldoAnterior.Text = "0,00";
            txtValorAbertura.Text = "0,00";

            novoCaixa = new Caixa();

            int IdCaixa = novoCaixa.Salvar(DateTime.Today, DateTime.Now, Convert.ToDecimal(txtTotal.Text), true);
            Caixa.AtualizarCaixa(IdCaixa);

            DataTable dadosCaixa = novoCaixa.Listar();
            ValorAbertura = Convert.ToDecimal(dadosCaixa.Rows[0]["SALDO_INICIAL"]);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void IniciaSaldoAnterior()
        {
            novoCaixa = new Caixa();

            decimal saldoAnterior = novoCaixa.SaldoAnterior();
            decimal valorAbertura = Convert.ToDecimal(txtValorAbertura.Text);

            decimal total = saldoAnterior + valorAbertura;

            int IdCaixa = novoCaixa.Salvar(DateTime.Today, DateTime.Now, total, true);
            Caixa.AtualizarCaixa(IdCaixa);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtValorAbertura_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (Convert.ToDecimal(txtValorAbertura.Text) + Convert.ToDecimal(txtSaldoAnterior.Text)).ToString();
        }
    }
}
