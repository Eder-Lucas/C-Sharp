using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e) => new frmAberturaCaixa().ShowDialog();
    }
}
