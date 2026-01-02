using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeDespesas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // Botão salvar
        private void contasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.despesasDataSet);

            // Atualiza a exibição dos dados na tela
            this.contasTableAdapter.Fill(this.despesasDataSet.Contas);
        }

        // Quando o form carregar
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Carrega dados na tabela 'despesasDataSet.Contas'
            this.contasTableAdapter.Fill(this.despesasDataSet.Contas);

            // Deixa o DataGridView da aba Pesquisar sem dados inicialmente
            dtgPesquisa.DataSource = null;
        }

        // Método que trata as pesquisas
        private void Pesquisar()
        {
            // Guarda o texto digitado sem espaços
            string texto = txtPesquisa.Text.Trim();

            // Guarda os dados que serão retornados da tabela
            DataTable dadosTabela; 

            // Se o RadioButton Categoria tiver marcado
            if (rbCategoria.Checked)
            {
                //Faz uma validação do conteúdo do txt
                if (decimal.TryParse(texto, out _) || string.IsNullOrWhiteSpace(texto))
                {
                    MessageBox.Show("Texto inválido. Por favor, insira uma categoria válida.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Se falhar coloca o foco do cursor no txt e retorna a função
                    // Impedindo a busca de dados
                    txtPesquisa.Focus();
                    return;
                }

                // Se passar na validação
                // Limpa o texto informativo
                lblInfo.Text = "";

                // Faz a consulta usando Data e Categoria como filtro
                // Salvando no DataTable: dadosTabela
                dadosTabela = contasTableAdapter.PesquisarCategoria(dtpData.Value.Date, texto);
            }

            // Se o RadioButton Valor tiver marcado
            else
            {
                //Valida o filtro fornecido pelo usuário
                if (!decimal.TryParse(txtPesquisa.Text, out decimal valor))
                {
                    MessageBox.Show("Valor inválido. Por favor, insira um número válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Impede o fluxo do código se falhar na validação
                    txtPesquisa.Focus();
                    return;
                }

                // Se não falhar
                // Limpa o Label informativo
                lblInfo.Text = "";

                // Faz a consulta usando a Data e Valor como filtro
                dadosTabela = contasTableAdapter.PesquisarValor(dtpData.Value.Date, valor);
            }

            // Atualiza o DataGridView com os dados filtrados
            // Mesmo que: dtgPesquisa.DataSource = contasTableAdapter.PesquisarValor(dtpData.Value.Date, valor);
            dtgPesquisa.DataSource = dadosTabela;

            // Verifica se o número de linhas retornadas foram 0
            // Ou seja, nada foi retornado
            if (dadosTabela.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum registro encontrado com os filtros selecionados.",
                       "Sem registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Quando clicar no botão pesquisar
        // Chama o método responsável pela busca de dados
        private void btnPesquisar_Click(object sender, EventArgs e) => Pesquisar();
    }
}
