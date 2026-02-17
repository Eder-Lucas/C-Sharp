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

            //Aciona o evento ao método AtualizarDadosDaAba toda vez que a aba for trocada
            tabControlClientes.SelectedIndexChanged += (s, e) => AtualizarDadosDaAba();
        }

        // Evento de clique do botão salvar na barra de navegação
        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzariaDataSet);
        }

        // Evento de load do formulário
        private void frmClientes_Load(object sender, EventArgs e)
        {
            // Carrega os dados da aba selecionada
            AtualizarDadosDaAba();

            // Aplicando ajustes visuais utilizando as classes
            DataGridViewUtils.AjustaBarraVertical(dtgClientes, dtgPesquisaCliente);
            FormataCursorMtb.AjustaCursor(this);
            CursorButton.HandToolStrip(clienteBindingNavigator);
            CursorButton.HandButton(this);
        }

        //Carrega os dados dependendo da aba selecionada
        private void AtualizarDadosDaAba()
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
            if (!String.IsNullOrWhiteSpace(txtPesquisaNome.Text))
            {
                dtgPesquisaCliente.DataSource = clienteTableAdapter.RetornarNomeCliente(txtPesquisaNome.Text);
            }
        }

        //Executa a pesquisa por CPF
        private void btnPesquisaCpf_Click(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = clienteTableAdapter.RetornarCpfCliente(txtPesquisaCpf.Text);            
        }

        // Executa a query que retorna todos os clientes
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = clienteTableAdapter.RetornarClientes();
        }

        //Executa a pesquisa por nome enquanto o usuário digita
        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = clienteTableAdapter.RetornarNomeCliente(txtPesquisaNome.Text);
        }
    }
}
