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
            dtgPedido.AutoGenerateColumns = false;
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

        private void btnpedidos_Click(object sender, EventArgs e)
        {
            new frmPedido().ShowDialog();

            btnPesquisar.PerformClick();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dtgPedido.DataSource = pedidoTableAdapter1.RetornarPedidos();
            VerificaPedido();

           DataGridViewUtils.AjustaBarraVertical(dtgPedido);
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
            else if (!String.IsNullOrEmpty(txtNomeCliente.Text))
            {
                dtgPedido.DataSource = pedidoTableAdapter1.RetornarCliente(txtNomeCliente.Text);
            }

            VerificaPedido();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dtgPedido.DataSource = pedidoTableAdapter1.RetornarPedidos();
            VerificaPedido();
            //fazer método limpar
        }

        private void chkEntregue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEntregue.Checked)
            {
                chkEspera.Enabled= false;
                txtNomeCliente.Enabled = false;

                dtgPedido.DataSource = pedidoTableAdapter1.RetornarEntregue();
            }
            else
            {
                chkEspera.Enabled = true;
                txtNomeCliente.Enabled = true;
            }

            VerificaPedido();
        }

        private void chkEspera_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspera.Checked)
            {
                chkEntregue.Enabled = false;
                txtNomeCliente.Enabled = false;

                dtgPedido.DataSource = pedidoTableAdapter1.RetornarEspera();
            }
            else
            {
                chkEntregue.Enabled = true;
                txtNomeCliente.Enabled = true;
            }

            VerificaPedido();
        }

        private void VerificaPedido()
        {
            int linha = dtgPedido.Rows.Count;

            if (linha > 0)
            {
                for (int i = 0; i < linha; i++)
                {
                    if (Convert.ToBoolean(dtgPedido.Rows[i].Cells["ENTREGUE"].Value))
                    {
                        dtgPedido.Rows[i].Cells["SITUACAO"].Value = "Entregue";
                        dtgPedido.Rows[i].Cells["SITUACAO"].Style.BackColor = Color.ForestGreen;
                        dtgPedido.Rows[i].Cells["SITUACAO"].Style.ForeColor = Color.White;
                    }
                    else
                    {
                        dtgPedido.Rows[i].Cells["SITUACAO"].Value = "À Espera";
                        dtgPedido.Rows[i].Cells["SITUACAO"].Style.BackColor = Color.DarkRed;
                        dtgPedido.Rows[i].Cells["SITUACAO"].Style.ForeColor = Color.White;
                    }
                } 
            }
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            dtgPedido.DataSource = pedidoTableAdapter1.RetornarCliente(txtNomeCliente.Text);

            VerificaPedido();
        }
    }
}
