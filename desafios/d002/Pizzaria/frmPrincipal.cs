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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();

            clientes.ShowDialog();
        }

        private void btnPizzas_Click(object sender, EventArgs e)
        {
            frmPizzas pizzas = new frmPizzas();

            pizzas.ShowDialog();
        }

        private void btnpedidos_Click(object sender, EventArgs e) => new frmPedido().ShowDialog();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dtgPedido.DataSource = pedidoTableAdapter1.RetornarPedidos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (chkEntregue.Checked)
            {
                dtgPedido.DataSource = pedidoTableAdapter1.RetornarEntregue();
            }
            else if (chkEspera.Checked)
            {
                dtgPedido.DataSource = pedidoTableAdapter1.RetornarEspera();
            }
            else if (String.IsNullOrEmpty(txtNomeCliente.Text))
            {
                dtgPedido.DataSource = pedidoTableAdapter1.RetornarPedidos();
            }
            else
            {
                dtgPedido.DataSource = pedidoTableAdapter1.RetornarCliente(txtNomeCliente.Text);
            }
        }

        private void chkEntregue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEntregue.Checked)
            {
                chkEspera.Enabled= false;
                txtNomeCliente.Enabled = false;
            }
            else
            {
                chkEspera.Enabled = true;
                txtNomeCliente.Enabled = true;
            }
        }

        private void chkEspera_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspera.Checked)
            {
                chkEntregue.Enabled = false;
                txtNomeCliente.Enabled = false;
            }
            else
            {
                chkEntregue.Enabled = true;
                txtNomeCliente.Enabled = true;
            }
        }
    }
}
