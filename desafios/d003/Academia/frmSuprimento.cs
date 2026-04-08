using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmSuprimento : Form
    {
        int idMensalidade;
        string valor;
        frmControleAlunos frmControleAlunos;

        public frmSuprimento(int idMensalidade, decimal valor, frmControleAlunos frmControleAlunos)
        {
            InitializeComponent();

            this.idMensalidade = idMensalidade;
            this.valor = valor.ToString();
            txtDinheiro.Text = this.valor;
            this.frmControleAlunos = frmControleAlunos;
        }

        private readonly Caixa novoCaixa = new();
        private readonly Mensalidades novaMensalidade = new();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dadosCaixa = novoCaixa.Listar();

                int idCaixa = Convert.ToInt32(dadosCaixa.Rows[0]["ID_CAIXA"]);
                decimal valor = Convert.ToDecimal(txtDinheiro.Text);
                var forma = cboFormaPagamento.Text;
                MessageBox.Show($"Valor: {valor} - Forma de pagamento: {forma}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                novoCaixa.SalvarTransacao(idCaixa, valor, "E", forma);
                MessageBox.Show("Suprimento registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                novaMensalidade.Pagar(idMensalidade, DateTime.Now.Date, true);
                frmControleAlunos.CarregarMensalidades();
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }           
        }
    }
}
