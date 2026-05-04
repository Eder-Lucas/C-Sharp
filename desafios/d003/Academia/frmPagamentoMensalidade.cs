using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmPagamentoMensalidade : Form
    {
        int idMensalidade;
        decimal valor;
        ucControleAlunos ucControleAlunos;
        List<decimal> valorLista;

        public frmPagamentoMensalidade(int idMensalidade, decimal valor, ucControleAlunos ucControleAlunos)
        {
            InitializeComponent();

            this.idMensalidade = idMensalidade;
            this.valor = valor;
            txtDinheiro.Text = $"{this.valor:C2}";
            this.ucControleAlunos = ucControleAlunos;
        }

        private readonly Caixa novoCaixa = new();
        private readonly Mensalidades novaMensalidade = new();

        private void frmSuprimento_Load(object sender, EventArgs e)
        {
            cboFormaPagamento.SelectedIndex = 0;
        }

        // Fecha o form ao clicar no botão cancelar
        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // dadosCaixa armazena todas as informações do caixa através do método listar
                DataTable dadosCaixa = novoCaixa.Listar();

                // Dados para pagar a mensalidade
                int meses = (int)numQuantosMeses.Value;
                DateTime dataAtualPagamento = DateTime.Now.Date;
                bool gerar = ConfigService.GetBool("GERAR_AUTO_MENSALIDADE");

                // Dados para salvar a transação no caixa
                int idCaixa = Convert.ToInt32(dadosCaixa.Rows[0]["ID_CAIXA"]);
                var forma = cboFormaPagamento.Text;

                // Executa o pagamaento e salva a transação do caixa
                valorLista = novaMensalidade.Pagar(idMensalidade, dataAtualPagamento, true, gerar, meses);

                decimal valorFinal = valorLista.Sum();

                novoCaixa.SalvarTransacao(idCaixa, valorFinal, "E", forma, "PAGAMENTO");

                MessageBox.Show(
                "Pagamento realizado com sucesso! Uma nova mensalidade foi gerada automaticamente para o próximo mês nessa turma, " +
                "verifique a lista de mensalidades. Você pode cancelar esta mensalidade caso inative a matrícula.",
                "Pagamento de mensalidades",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                // Recarrega as mensalidades e matrículas do frmControleAlunos
                ucControleAlunos.CarregarMensalidades();
                ucControleAlunos.ListarMatriculas();

                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Sempre que o valor do numQuantosMeses for alterado, atualiza o valor total a ser pago
        private void numQuantosMeses_ValueChanged(object sender, EventArgs e)
        {
            int meses = (int)numQuantosMeses.Value;
            List<decimal> valores = novaMensalidade.ObterValores(meses, idMensalidade);

            decimal total = valores.Sum();

            txtDinheiro.Text = $"{total:C2}";
        }
    }
}