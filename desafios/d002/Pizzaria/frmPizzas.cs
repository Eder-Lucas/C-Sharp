using Pizzaria.PizzariaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class frmPizzas : Form
    {
        public frmPizzas()
        {
            InitializeComponent();
        }

        // Quando o formulário carregar
        private void frmPizzas_Load(object sender, EventArgs e)
        {
            // Lista os dados de sabores e tamanhos
            ListarSabores();
            ListarTamanhos();

            // Aplica os ajustes visuais utilizando as classes
            DataGridViewUtils.AjustaBarraVertical(dtgSabores, dtgTamanhos);
            CursorUtils.HandButton(this);
        }

        // Método para listar todos os sabores
        public void ListarSabores()
        {
            dtgSabores.DataSource = saborTableAdapter1.RetornarSabores();
        }

        // Método para listar todos os tamanhos
        public void ListarTamanhos()
        {
            dtgTamanhos.DataSource = tamanhoTableAdapter1.RetornarTamanhos();
        }

        // Método para limpar os campos
        public void LimparCampos(Control parent)
        {
            foreach (Control ctl in parent.Controls)
            {
                // Ignora o campo de pesquisa para não limpar a pesquisa realizada
                if (ctl.Name == "txtPesquisa") continue;

                // Limpa os TextBox, exceto se tiver a tag "zero", onde o valor é definido como "0
                if (ctl is TextBox txt)
                {
                    txt.Text = (txt.Tag?.ToString() == "zero") ? "0" : string.Empty;
                }

                // Caso haja controles aninhados
                // Ex: GroupBox, Panel, TabPage, etc
                if (ctl.HasChildren)
                    LimparCampos(ctl);         
            }
        }

        //Método que finaliza as consultas no banco
        private void FinalizaConsulta(string msg, Control tabPage, bool sabor)
        {
            // Mensagem de sucesso
            MessageBox.Show(msg, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // Atualiza o DataGridView dependendo da aba onde a ação foi realizada
            if (sabor)
                ListarSabores();
            else
                ListarTamanhos();

            // Limpa os campos dessa aba
            LimparCampos(tabPage);
        }

        // ----------ABA SABORES---------- //

        // Ao clicar no botão novo, limpa os campos para cadastrar um novo sabor
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos(tabPageSabores);
        }

        // Ao clicar no botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verifica se o código é igual a zero, se sim salva um novo sabor
            if (txtCodigo.Text == "0")
            {
                // Executa a query de salvar
                saborTableAdapter1.Salvar(txtNome.Text, txtIngrediente.Text);

                // Finaliza o salvamento
                FinalizaConsulta("Sabor salvo com sucesso!", tabPageSabores, true); 
            }
            // Caso contrário, se for diferente de zero altera o sabor
            else
            {
                // Executa a query de alteração
                saborTableAdapter1.Alterar(txtNome.Text, txtIngrediente.Text, Convert.ToInt32(txtCodigo.Text));

                // Finaliza a alteração
                FinalizaConsulta("Sabor alterado com sucesso!", tabPageSabores, true);
            }
        }

        // Ao clicar no botão excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se o código é diferente de zero
            // Se sim, significa que há um sabor selecionado podendo excluí-lo
            if (txtCodigo.Text != "0")
            {
                // Executa a query de exclusão
                saborTableAdapter1.Excluir(Convert.ToInt32(txtCodigo.Text));

                FinalizaConsulta("Sabor excluído com sucesso!", tabPageSabores, true);
            }
        }

        // Ao clicar no botão de pesquisar
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            // Executa a query de pesquisa pelo nome
            dtgSabores.DataSource = saborTableAdapter1.PesquisaNomeSabor(txtPesquisa.Text);

            // Limpa os campos
            LimparCampos(tabPageSabores);
        }

        // Executa a pesquisa enquanto o usuário digita no campo de pesquisa
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Executa a query de pesquisa pelo nome
            dtgSabores.DataSource = saborTableAdapter1.PesquisaNomeSabor(txtPesquisa.Text);

            // Limpa os campos
            LimparCampos(tabPageSabores);
        }

        // Ao clicar duas vezes em um sabor no DataGridView
        private void dtgSabores_DoubleClick(object sender, EventArgs e)
        {
            // Preenche os campos com os dados do sabor selecionado
            txtCodigo.Text = dtgSabores.Rows[dtgSabores.CurrentRow.Index].Cells["CODIGO"].Value.ToString();
            txtNome.Text = dtgSabores.Rows[dtgSabores.CurrentRow.Index].Cells["NOME"].Value.ToString();
            txtIngrediente.Text = dtgSabores.Rows[dtgSabores.CurrentRow.Index].Cells["INGREDIENTES"].Value.ToString();
        }

        // ----------ABA TAMANHOS---------- //

        // Ao clicar no botão novo, limpa os campos para cadastrar um novo tamanho
        private void btnNovoTamanho_Click(object sender, EventArgs e)
        {
            LimparCampos(this);
        }

        // Ao clicar no botão salvar
        private void btnSalvarTamanho_Click(object sender, EventArgs e)
        {
            // Verifica se o código é igual a zero, se sim salva um novo sabor
            if (txtCodigoTamanho.Text == "0")
            {
                // Executa a query de salvar
                tamanhoTableAdapter1.SalvarTamanho(txtNomeTamanho.Text, Convert.ToDecimal(txtValorTamanho.Text));

                // Exibe a mensagem de sucesso
                MessageBox.Show(
                    "Tamanho salvo com sucesso!", "Salvando sabor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );

                // Atualiza a lista de sabores e limpa os campos
                ListarTamanhos();
                LimparCampos(this);
            }
            // Caso contrário, se for diferente de zero altera o sabor
            else
            {
                // Executa a query de alteração
                tamanhoTableAdapter1.AlterarTamanho(txtNomeTamanho.Text, Convert.ToDecimal(txtValorTamanho.Text), Convert.ToInt32(txtCodigoTamanho.Text));

                // Exibe a mensagem de sucesso
                MessageBox.Show(
                    "Tamanho alterado com sucesso!", "Alterando sabor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );

                // Atualiza a lista de sabores e limpa os campos
                ListarTamanhos();
                LimparCampos(this);
            }
        }

        // Ao clicar no botão excluir
        private void btnExcluirTamanho_Click(object sender, EventArgs e)
        { 
            // Verifica se o código é diferente de zero
            // Se sim, significa que há um sabor selecionado podendo excluí-lo
            if (txtCodigoTamanho.Text != "0")
            {
                // Executa a query de exclusão
                tamanhoTableAdapter1.ExcluirTamanho(Convert.ToInt32(txtCodigoTamanho.Text));

                // Exibe a mensagem de sucesso
                MessageBox.Show(
                    "Tamanho excluído com sucesso!", "Excluindo sabor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );

                // Atualiza a lista de sabores e limpa os campos
                ListarTamanhos();
                LimparCampos(this);
            }
        }

        // Ao clicar duas vezes em um tamanho no DataGridView
        private void dtgTamanhos_DoubleClick(object sender, EventArgs e)
        {
            // Preenche os campos com os dados do tamanho selecionado
            // dtgTamanhos.CurrentRow?.DataBoundItem: retorna o objeto vinculado à linha selecionada
            // is DataRowView drv: verifica se é um DataRowView, tipo usado para representar uma linha de dados em um DataGridView
            if (dtgTamanhos.CurrentRow?.DataBoundItem is DataRowView drv)
            {
                txtCodigoTamanho.Text = drv["CODIGO_TAMANHO"].ToString();
                txtNomeTamanho.Text = drv["NOME_TAMANHO"].ToString();
                txtValorTamanho.Text = drv["VALOR"].ToString();
            }

            /* Forma mais verbosa
                txtCodigoTamanho.Text = dtgTamanhos.Rows[dtgTamanhos.CurrentRow.Index].Cells["CODIGO_TAMANHO"].Value.ToString();
                txtNomeTamanho.Text = dtgTamanhos.Rows[dtgTamanhos.CurrentRow.Index].Cells["NOME_TAMANHO"].Value.ToString();
                txtValorTamanho.Text = dtgTamanhos.Rows[dtgTamanhos.CurrentRow.Index].Cells["VALOR"].Value.ToString();
            */
        }
    }
}
