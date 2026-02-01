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

        public void ListarSabores()
        {
            dtgSabores.DataSource = saborTableAdapter1.RetornarSabores();
        }

        public void Limpar()
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtIgrediente.Clear();
        }

        private void frmPizzas_Load(object sender, EventArgs e)
        {
            ListarSabores();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            saborTableAdapter1.Salvar(txtNome.Text, txtIgrediente.Text);

            MessageBox.Show(
                "Sabor salvo com sucesso!", "Salvamento de Sabor",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );

            ListarSabores();
            Limpar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dtgSabores.DataSource = saborTableAdapter1.PesquisaNomeSabor(txtPesquisa.Text);

            Limpar();
        }
    }
}
