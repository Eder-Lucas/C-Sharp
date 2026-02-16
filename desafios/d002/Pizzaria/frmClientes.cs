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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();

            //Aciona o evento ao método
            tabControlClientes.SelectedIndexChanged += (s, e) => CarregaAbaAtual();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzariaDataSet);
        }

        //Chama o método ao carregar o formulário
        private void frmClientes_Load(object sender, EventArgs e)
        {
            CarregaAbaAtual();
            DataGridViewUtils.AjustaBarraVertical(dtgClientes, dtgPesquisaCliente);
        }

        //Carrega os dados dependendod da aba selecionada
        private void CarregaAbaAtual()
        {
            //Verifica a aba selecionada
            switch (tabControlClientes.SelectedTab.Name)
            {
                //Na aba clientes, carrega os dados preenchendo o datagrid
                case "tabPageClientes":
                    if (this.pizzariaDataSet.Cliente.Count == 0)
                        this.clienteTableAdapter.Fill(this.pizzariaDataSet.Cliente);
                    break;

                //Na aba pesquisa, limpa o datagrid
                case "tabPagePesquisa":
                    dtgPesquisaCliente.DataSource = null;
                    break;
            }
        }

        //Executa a pesquisa por nome
        private void btnPesquisaNome_Click(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = clienteTableAdapter.RetornarNomeCliente(txtPesquisaNome.Text);
        }

        //Executa a pesquisa por CPF
        private void btnPesquisaCpf_Click(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = clienteTableAdapter.RetornarCpfCliente(txtPesquisaCpf.Text);
        }

        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = clienteTableAdapter.RetornarNomeCliente(txtPesquisaNome.Text);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = clienteTableAdapter.RetornarClientes();
        }
    }
}
