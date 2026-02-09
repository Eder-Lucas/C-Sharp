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

        //Método para listar todos os sabores
        public void ListarSabores()
        {
            dtgSabores.DataSource = saborTableAdapter1.RetornarSabores();
        }

        //Método para listar todos os tamanhos
        public void ListarTamanhos()
        {
            dtgTamanhos.DataSource = tamanhoTableAdapter1.RetornarTamanhos();
        }

        //Método para limpar os campos
        public void LimparCampos(Control parent)
        {
            foreach (Control ctl in parent.Controls)
            {
                if (ctl.Name == "txtPesquisa") continue;

                if (ctl is TextBox txt)
                {
                    txt.Text = (txt.Tag?.ToString() == "zero") ? "0" : string.Empty;
                }

                if (ctl.HasChildren)
                    LimparCampos(ctl);         
            }
        }

        // ----------ABA SABORES---------- //

        //Ao clicar no botão novo, limpa os campos para cadastrar um novo sabor
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos(this);
        }

        //Ao clicar no botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verifica se o código é igual a zero, se sim salva um novo sabor
            if (txtCodigo.Text == "0")
            {
                //Executa a query de salvar
                saborTableAdapter1.Salvar(txtNome.Text, txtIngrediente.Text);

                //Exibe a mensagem de sucesso
                MessageBox.Show(
                    "Sabor salvo com sucesso!", "Salvando sabor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );

                //Atualiza a lista de sabores e limpa os campos
                ListarSabores();
                LimparCampos(this); 
            }
            //Caso contrário, se for diferente de zero altera o sabor
            else
            {
                //Executa a query de alteração
                saborTableAdapter1.Alterar(txtNome.Text, txtIngrediente.Text, Convert.ToInt32(txtCodigo.Text));

                //Exibe a mensagem de sucesso
                MessageBox.Show(
                    "Sabor alterado com sucesso!", "Alterando sabor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );

                //Atualiza a lista de sabores e limpa os campos
                ListarSabores();
                LimparCampos(this);
            }
        }

        //Ao clicar no botão excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verifica se o código é diferente de zero
            //Se sim, significa que há um sabor selecionado podendo excluí-lo
            if (txtCodigo.Text != "0")
            {
                //Executa a query de exclusão
                saborTableAdapter1.Excluir(Convert.ToInt32(txtCodigo.Text));

                //Exibe a mensagem de sucesso
                MessageBox.Show(
                    "Sabor excluído com sucesso!", "Excluindo sabor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );

                //Atualiza a lista de sabores e limpa os campos
                ListarSabores();
                LimparCampos(this);
            }
        }

        //Ao clicar no botão de pesquisar
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            //Executa a query de pesquisa pelo nome
            dtgSabores.DataSource = saborTableAdapter1.PesquisaNomeSabor(txtPesquisa.Text);

            //Limpa os campos
            LimparCampos(this);
        }

        //Ao clicar duas vezes em um sabor no DataGridView
        private void dtgSabores_DoubleClick(object sender, EventArgs e)
        {
            //Preenche os campos com os dados do sabor selecionado
            txtCodigo.Text = dtgSabores.Rows[dtgSabores.CurrentRow.Index].Cells["CODIGO"].Value.ToString();
            txtNome.Text = dtgSabores.Rows[dtgSabores.CurrentRow.Index].Cells["NOME"].Value.ToString();
            txtIngrediente.Text = dtgSabores.Rows[dtgSabores.CurrentRow.Index].Cells["INGREDIENTES"].Value.ToString();
        }

        // ----------ABA TAMANHOS---------- //

        //Ao clicar no botão novo, limpa os campos para cadastrar um novo tamanho
        private void btnNovoTamanho_Click(object sender, EventArgs e)
        {
            LimparCampos(this);
        }

        //Ao clicar no botão salvar
        private void btnSalvarTamanho_Click(object sender, EventArgs e)
        {
            //Verifica se o código é igual a zero, se sim salva um novo sabor
            if (txtCodigoTamanho.Text == "0")
            {
                //Executa a query de salvar
                tamanhoTableAdapter1.SalvarTamanho(txtNomeTamanho.Text, Convert.ToDecimal(txtValorTamanho.Text));

                //Exibe a mensagem de sucesso
                MessageBox.Show(
                    "Tamanho salvo com sucesso!", "Salvando sabor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );

                //Atualiza a lista de sabores e limpa os campos
                ListarTamanhos();
                LimparCampos(this);
            }
            //Caso contrário, se for diferente de zero altera o sabor
            else
            {
                //Executa a query de alteração
                tamanhoTableAdapter1.AlterarTamanho(txtNomeTamanho.Text, Convert.ToDecimal(txtValorTamanho.Text), Convert.ToInt32(txtCodigoTamanho.Text));

                //Exibe a mensagem de sucesso
                MessageBox.Show(
                    "Tamanho alterado com sucesso!", "Alterando sabor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );

                //Atualiza a lista de sabores e limpa os campos
                ListarTamanhos();
                LimparCampos(this);
            }
        }

        //Ao clicar no botão excluir
        private void btnExcluirTamanho_Click(object sender, EventArgs e)
        {
            //Verifica se o código é diferente de zero
            //Se sim, significa que há um sabor selecionado podendo excluí-lo
            if (txtCodigoTamanho.Text != "0")
            {
                //Executa a query de exclusão
                tamanhoTableAdapter1.ExcluirTamanho(Convert.ToInt32(txtCodigoTamanho.Text));

                //Exibe a mensagem de sucesso
                MessageBox.Show(
                    "Tamanho excluído com sucesso!", "Excluindo sabor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );

                //Atualiza a lista de sabores e limpa os campos
                ListarTamanhos();
                LimparCampos(this);
            }
        }

        //Ao clicar duas vezes em um tamanho no DataGridView
        private void dtgTamanhos_DoubleClick(object sender, EventArgs e)
        {
            //Preenche os campos com os dados do tamanho selecionado
            txtCodigoTamanho.Text = dtgTamanhos.Rows[dtgTamanhos.CurrentRow.Index].Cells["CODIGO_TAMANHO"].Value.ToString();
            txtNomeTamanho.Text = dtgTamanhos.Rows[dtgTamanhos.CurrentRow.Index].Cells["NOME_TAMANHO"].Value.ToString();
            txtValorTamanho.Text = dtgTamanhos.Rows[dtgTamanhos.CurrentRow.Index].Cells["VALOR"].Value.ToString();
        }

        //Quando o formulário carregar, listar os dados de sabores e tamanhos
        private void frmPizzas_Load(object sender, EventArgs e)
        {
            ListarSabores();
            ListarTamanhos();
        }
    }
}
