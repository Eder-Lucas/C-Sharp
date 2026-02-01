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
            txtIgrediente.Clear();
        }

        //Quando o formulário carregar, listar os sabores
        private void frmPizzas_Load(object sender, EventArgs e)
        {
            ListarSabores();
        }

        //Ao clicar no botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Executa a query de salvar
            saborTableAdapter1.Salvar(txtNome.Text, txtIngrediente.Text);

            //Exibe a mensagem de sucesso
            MessageBox.Show(
                "Sabor salvo com sucesso!", "Salvamento de Sabor",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );

            //Atualiza a lista de sabores e limpa os campos
            ListarSabores();
            Limpar();
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
    }
}
