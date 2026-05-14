using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class ucCaixa : UserControl
    {
        private readonly frmPrincipal formularioPrincipal;
        private readonly int idCaixa;

        public ucCaixa(frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;

            this.DoubleBuffered = true;
            idCaixa = frmPrincipal.IdCaixa;
        }

        private readonly Caixa novoCaixa = new();
        public decimal valorAbertura;

        private async void ucCaixa_Load(object sender, EventArgs e)
        {
            dtgCaixa.AutoGenerateColumns = false;
            DataGridViewUtils.RemoveOrdenacao(dtgCaixa);
            AtualizaComponentes();
            ListarDetalhesCaixa();

            // Carrega os tipos de movimento para o comboBox
            var filtroMovimento = novoCaixa.ObterFiltro("Movimento").ToList();
            cboMovimento.DisplayMember = "Key";
            cboMovimento.ValueMember = "Value";
            cboMovimento.DataSource = filtroMovimento;
            cboMovimento.SelectedIndex = 0;

            var filtroPagamento = novoCaixa.ObterFiltro("Pagamento").ToList();
            cboTipoPagamento.DisplayMember = "Key";
            cboTipoPagamento.ValueMember = "Value";
            cboTipoPagamento.DataSource = filtroPagamento;
            cboTipoPagamento.SelectedIndex = 0;

            // Impede o flicker (piscadas ao carregar o uc)
            typeof(DataGridView)
            .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
            ?.SetValue(dtgCaixa, true, null);
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
            bool caixaAberto = novoCaixa.CaixaAberto(idCaixa);

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

            lblCaixaId.Enabled = caixaAberto;
            lblCaixaId.Visible = caixaAberto;
            lblDataAbertura.Enabled = caixaAberto;
            lblDataAbertura.Visible = caixaAberto;

            if (!caixaAberto) return;

            DataTable dadosCaixa = novoCaixa.Listar();

            var dia = Convert.ToDateTime(dadosCaixa.Rows[0]["DIA"]);
            TimeSpan hora = (TimeSpan)dadosCaixa.Rows[0]["HORA"];

            lblCaixaId.Text = $"Caixa #{idCaixa}";
            lblDataAbertura.Text = $"Aberto em: {dia:dd/MM/yyyy} às {hora:hh\\:mm\\:ss}";

            dtpDataPagamento.Value = dia;
        }

        public void ListarDetalhesCaixa()
        {
            try
            {
                DataTable dadosCaixa = novoCaixa.Listar();
                valorAbertura = Convert.ToDecimal(dadosCaixa.Rows[0]["SALDO_INICIAL"]);

                dtgCaixa.DataSource = novoCaixa.ListaTransacao(idCaixa);

                // Formata a visualização dos dados para moeda e data
                dtgCaixa.Columns?["VALOR"]?.DefaultCellStyle.Format = "C2";
                dtgCaixa.Columns?["VALOR"]?.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("pt-BR");
                dtgCaixa.Columns?["DATA"]?.DefaultCellStyle.Format = "dd/MM/yyyy";

                var (entrada, retirada, saldo) = novoCaixa.ObterTotal(valorAbertura, idCaixa);

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
                    if (Convert.ToString(drv["TIPO_MOVIMENTO"]) is not string movimento) break;

                    if (!Enum.TryParse(movimento, out TipoMovimento tipo)) break;

                    if (mapaMovimento.TryGetValue(tipo, out var estilo))
                        e.Value = estilo.icone;

                    e.FormattingApplied = true;
                    break;
            }
        }

        private void dtgCaixa_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (sender is not DataGridView dtg) return;

            var linha = dtg.Rows[e.RowIndex];

            if (linha.DataBoundItem is not DataRowView drv) return;

            if (Convert.ToString(drv["TIPO_MOVIMENTO"]) is not string movimento) return;

            if (!Enum.TryParse(movimento, out TipoMovimento tipo)) return;

            if (mapaMovimento.TryGetValue(tipo, out var estilo))
            {
                linha.DefaultCellStyle.BackColor = estilo.fundo;
                linha.DefaultCellStyle.SelectionBackColor = estilo.selecao;
                linha.DefaultCellStyle.ForeColor = Color.White;
            }
        }

        // Mapa para associar cada tipo de movimento a um estilo de formatação específico
        private readonly Dictionary<TipoMovimento, (Color fundo, Color selecao, Image icone)> mapaMovimento = new()
        {
            { TipoMovimento.SUPRIMENTO, (Color.Green, Color.DarkGreen, Properties.Resources.setaCima_menor) },
            { TipoMovimento.RETIRADA, (Color.Red, Color.DarkRed, Properties.Resources.setaBaixo_menor) },
            { TipoMovimento.PAGAMENTO, (Color.FromArgb(255, 140, 0), Color.FromArgb(184, 83, 0), Properties.Resources.pagamento_menor) }
        };

        private enum TipoMovimento
        {
            SUPRIMENTO,
            RETIRADA,
            PAGAMENTO
        }

        // Faz a pesquisa usando os filtros
        private void EventoFiltro(object sender, EventArgs e)
        {
            if (cboMovimento.SelectedValue == null || cboTipoPagamento.SelectedValue == null) return;

            string movimento = cboMovimento.SelectedValue.ToString() ?? "";
            string pagamento = cboTipoPagamento.SelectedValue.ToString() ?? "";
            DateTime data = dtpDataPagamento.Value.Date;

            dtgCaixa.DataSource = novoCaixa.Pesquisar(idCaixa, movimento, pagamento, data);
        }
    }
}
