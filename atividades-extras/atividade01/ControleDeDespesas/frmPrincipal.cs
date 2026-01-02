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

        //botão salvar
        private void contasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.despesasDataSet);

            //atualiza a exibição dos dados na tela
            this.contasTableAdapter.Fill(this.despesasDataSet.Contas);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Carrega dados na tabela 'despesasDataSet.Contas'
            this.contasTableAdapter.Fill(this.despesasDataSet.Contas);

            dtgPesquisa.DataSource = null;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();          
        }

        private void Pesquisar()
        {
            string texto = txtPesquisa.Text.Trim();
            DataTable tabela;

            if (rbCategoria.Checked)
            {
                if (decimal.TryParse(texto, out _) || string.IsNullOrWhiteSpace(texto))
                {
                    MessageBox.Show("Texto inválido. Por favor, insira uma categoria válida.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtPesquisa.Focus();
                    return;
                }

                lblInfo.Text = "";
                tabela = contasTableAdapter.PesquisarCategoria(dtpData.Value.Date, texto);
            }
            else
            {
                if (!decimal.TryParse(txtPesquisa.Text, out decimal valor))
                {
                    MessageBox.Show("Valor inválido. Por favor, insira um número válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtPesquisa.Focus();
                    return;
                }

                lblInfo.Text = "";
                tabela = contasTableAdapter.PesquisarValor(dtpData.Value.Date, valor);
            }


            dtgPesquisa.DataSource = tabela;

            if (tabela.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum registro encontrado com os filtros selecionados.",
                       "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
