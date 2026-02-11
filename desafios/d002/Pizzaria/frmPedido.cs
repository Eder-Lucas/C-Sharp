using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzariaDataSet);
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pizzariaDataSet.Sabor'. Você pode movê-la ou removê-la conforme necessário.
            this.saborTableAdapter.Fill(this.pizzariaDataSet.Sabor);
            // TODO: esta linha de código carrega dados na tabela 'pizzariaDataSet.Tamanho'. Você pode movê-la ou removê-la conforme necessário.
            this.tamanhoTableAdapter.Fill(this.pizzariaDataSet.Tamanho);
            // TODO: esta linha de código carrega dados na tabela 'pizzariaDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.pizzariaDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'pizzariaDataSet.Pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoTableAdapter.Fill(this.pizzariaDataSet.Pedido);

        }

        private void vALORTextBox_TextChanged(object sender, EventArgs e)
        {
            tOTALTextBox.Text = vALORTextBox.Text;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (cboCliente.Items.Count > 0) cboCliente.SelectedIndex = 0;
            if (cboTamanho.Items.Count > 0) cboTamanho.SelectedIndex = 0;
            if (cboSabor.Items.Count > 0) cboSabor.SelectedIndex = 0;

            chkEntregue.Checked = false;
        }
    }
}
