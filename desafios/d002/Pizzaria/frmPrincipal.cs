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
    }
}
