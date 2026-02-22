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

        // Ao clicar em salvar
        private void pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzariaDataSet);
        }

        // Evento de load do formulário
        private void frmPedido_Load(object sender, EventArgs e)
        {
            // Carregando os dados nas tabelas
            this.saborTableAdapter.Fill(this.pizzariaDataSet.Sabor);
            this.tamanhoTableAdapter.Fill(this.pizzariaDataSet.Tamanho);
            this.clienteTableAdapter.Fill(this.pizzariaDataSet.Cliente);
            this.pedidoTableAdapter.Fill(this.pizzariaDataSet.Pedido);

            // Aplicando ajustes visuais utilizando as classes
            CursorUtils.AjustaCursorMaskedTextBox(this);
            CursorUtils.HandToolStripButton(pedidoBindingNavigator);
            CursorUtils.HandButton(this);
        }

        // Atribui o valor da pizza ao campo total
        private void vALORTextBox_TextChanged(object sender, EventArgs e)
        {
            tOTALTextBox.Text = vALORTextBox.Text;
        }

        // Ao clicar em adicionar novo pedido
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Define os valores como padrão
            if (cboTamanho.Items.Count > 0) cboTamanho.SelectedIndex = 1;
            if (cboSabor.Items.Count > 0) cboSabor.SelectedIndex = 1;

            // Força o checkBox a iniciar como desmarcado
            chkEntregue.Checked = false;
        }
    }
}