using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmCaixa : Form
    {
        public frmPrincipal formularioPrincipal;

        public frmCaixa(frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        private readonly Caixa novoCaixa = new();
        public decimal valorAbertura;

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            AtualizaComponentes();
            ListarDetalhesCaixa();
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            // Exibe o form de abertura de caixa e armazena a resposta do usuário
            var formAbertura = new frmAberturaCaixa();
            var result = formAbertura.ShowDialog() == DialogResult.OK;

            // Se for true significa que o caixa foi aberto, atualizando a UI
            if (result)
            {
                valorAbertura = formAbertura.ValorAbertura;

                ListarDetalhesCaixa();
                AtualizaComponentes();
                formularioPrincipal.VerificaSituacaoCaixa();
            }
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                bool fechar = MessageBox.Show(
                    "Deseja realmente fechar o caixa?",
                    "Deseja fechar?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes;

                if (fechar)
                {
                    DataTable dadosCaixa = novoCaixa.Listar();
                    int idCaixa = Convert.ToInt32(dadosCaixa.Rows[0]["ID_CAIXA"]);

                    // Fecha o caixa
                    novoCaixa.AlterarSituacao(idCaixa, false);
                    formularioPrincipal.VerificaSituacaoCaixa();
                    AtualizaComponentes();

                    MessageBox.Show("Caixa fechado com sucesso!", "Caixa fechado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chamando o formulário de suprimento e retirada ao clicar no seu respectivo botão
        private void btnSuprimento_Click(object sender, EventArgs e)
        {
            frmSuprimento suprimento = new(this);
            suprimento.ShowDialog();
        }

        private void btnRetirada_Click(object sender, EventArgs e)
        {
            frmRetirada retirada = new(this);
            retirada.ShowDialog();
        }

        // Atualiza os componentes dependendo da situação do caixa
        private void AtualizaComponentes()
        {
            DataTable dadosCaixa = novoCaixa.Listar();

            var situacao = dadosCaixa.Rows[0]["SITUACAO"];
            
            bool caixaAberto = Convert.ToBoolean(situacao);

            btnFecharCaixa.Enabled = caixaAberto;
            btnFecharCaixa.Visible = caixaAberto;

            btnAbrirCaixa.Visible = !caixaAberto;
            btnAbrirCaixa.Enabled = !caixaAberto;

            btnRetirada.Enabled = caixaAberto;
            btnSuprimento.Enabled = caixaAberto;

            lblInicial.Enabled = caixaAberto;
            lblEntrada.Enabled = caixaAberto;
            lblRetirada.Enabled = caixaAberto;
            lblSaldo.Enabled = caixaAberto;
        }

        public void ListarDetalhesCaixa()
        {
            try
            {
                dtgCaixa.DataSource = novoCaixa.ListaTransacao();

                DataTable dadosCaixa = novoCaixa.Listar();
                valorAbertura = Convert.ToDecimal(dadosCaixa.Rows[0]["SALDO_INICIAL"]);

                var (entrada, retirada, saldo) = novoCaixa.ObterTotal(valorAbertura);

                lblInicial.Text = valorAbertura.ToString("C");
                lblEntrada.Text = entrada.ToString("C");
                lblRetirada.Text = retirada.ToString("C");
                lblSaldo.Text = saldo.ToString("C");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dtgCaixa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (sender is not DataGridView dtg) return;
            if (e.ColumnIndex < 0) return;

            var coluna = dtg.Columns[e.ColumnIndex].Name;
            var linha = dtg.Rows[e.RowIndex];

            if (linha.DataBoundItem is not DataRowView drv) return;

            switch (coluna)
            {
                // Adiciona uma imagem na linha referente ao tipo do movimento
                case "IMAGEM":
                    var movimento = Convert.ToString(drv["MOVIMENTO"]);

                    if (movimento == "E")
                        e.Value = Properties.Resources.setaCima_menor;
                    else if (movimento == "S")
                        e.Value = Properties.Resources.setaBaixo_menor;

                    e.FormattingApplied = true;
                    break;
            }
        }
    }
}

