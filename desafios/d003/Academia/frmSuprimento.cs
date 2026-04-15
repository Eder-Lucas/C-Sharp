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
        decimal valor;
        frmControleAlunos frmControleAlunos;

        public frmSuprimento(int idMensalidade, decimal valor, frmControleAlunos frmControleAlunos)
        {
            InitializeComponent();

            this.idMensalidade = idMensalidade;
            this.valor = valor;
            txtDinheiro.Text = this.valor.ToString();
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
                int meses = (int)numQuantosMeses.Value;
                DateTime dataAtualPagamento = DateTime.Now.Date;

                bool gerar = MessageBox.Show(
                "Deseja gerar a próxima mensalidade?",
                "Pagamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes;

                novaMensalidade.Pagar(idMensalidade, dataAtualPagamento, true, gerar, meses);
                novoCaixa.SalvarTransacao(idCaixa, valor, "E", forma);

                MessageBox.Show(
                "Pagamento realizado com sucesso! Uma nova mensalidade foi gerada automaticamente para o próximo mês nessa turma, " +
                "verifique a lista de mensalidades. Você pode cancelar esta mensalidade caso inative a matrícula.",
                "Pagamento de mensalidades",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                frmControleAlunos.CarregarMensalidades();
                frmControleAlunos.ListarMatriculas();

                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void numQuantosMeses_ValueChanged(object sender, EventArgs e)
        {
            int meses = (int)numQuantosMeses.Value;
            decimal valorTotal = valor * meses;

            txtDinheiro.Text = valorTotal.ToString("F2");
        }
    }
}
