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
         private readonly frmCaixa formCaixa;

        public frmRetirada(frmCaixa formulario)
        {
            InitializeComponent();
            this.formCaixa = formulario;
        }

        private readonly Caixa novoCaixa = new();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Armazena os dados para salvar a transação de retirada
            DataTable dadosCaixa = novoCaixa.Listar();
            int idCaixa = Convert.ToInt32(dadosCaixa.Rows[0]["ID_CAIXA"]);
            decimal valor = Convert.ToDecimal(txtValor.Text);
            string forma = cboFormaPagamento.Text;

            // Executa a retirada
            novoCaixa.SalvarTransacao(idCaixa, valor, "S", forma, "RETIRADA");

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
