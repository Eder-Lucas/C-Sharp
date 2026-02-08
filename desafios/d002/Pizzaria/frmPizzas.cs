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

        //Método para limpar os campos
        public void Limpar()
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtIngrediente.Clear();
        }

        //Quando o formulário carregar, listar os sabores
        private void frmPizzas_Load(object sender, EventArgs e)
        {
            ListarSabores();
        }

        //Ao clicar no botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
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
                Limpar(); 
            }
            else
            {
                saborTableAdapter1.Alterar(txtNome.Text, txtIngrediente.Text, Convert.ToInt32(txtCodigo.Text));

                //Exibe a mensagem de sucesso
                MessageBox.Show(
                    "Sabor alterado com sucesso!", "Alterando sabor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );

                //Atualiza a lista de sabores e limpa os campos
                ListarSabores();
                Limpar();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        //Ao clicar no botão de pesquisar
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            //Executa a query de pesquisa pelo nome
            dtgSabores.DataSource = saborTableAdapter1.PesquisaNomeSabor(txtPesquisa.Text);

            //Limpa os campos
            Limpar();
        }

        private void dtgSabores_DoubleClick(object sender, EventArgs e)
        {
            txtCodigo.Text = dtgSabores.Rows[dtgSabores.CurrentRow.Index].Cells["CODIGO"].Value.ToString();
            txtNome.Text = dtgSabores.Rows[dtgSabores.CurrentRow.Index].Cells["NOME"].Value.ToString();
            txtIngrediente.Text = dtgSabores.Rows[dtgSabores.CurrentRow.Index].Cells["INGREDIENTES"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
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
                Limpar();
            }
        }
    }
}
