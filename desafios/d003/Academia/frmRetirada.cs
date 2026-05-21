using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmRetirada : Form
    {
        private readonly ucCaixa formCaixa;

        public frmRetirada(ucCaixa formulario)
        {
            InitializeComponent();
            this.formCaixa = formulario;
        }

        private readonly Caixa novoCaixa = new();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Armazena os dados para salvar a transação de retirada
            decimal valor = Convert.ToDecimal(txtValor.Text);
            string forma = cboFormaPagamento.Text;

            // Executa a retirada
            novoCaixa.SalvarTransacao(Caixa.IdCaixa, valor, "S", forma, "RETIRADA");

            MessageBox.Show(
            "Retirada realizada com sucesso!",
            "Sucesso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            formCaixa.ListarDetalhesCaixa();

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
