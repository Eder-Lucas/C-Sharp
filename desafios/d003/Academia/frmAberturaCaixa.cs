using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmAberturaCaixa : Form
    {
        public frmAberturaCaixa()
        {
            InitializeComponent();
        }

        private void frmAberturaCaixa_Load(object sender, EventArgs e)
        {
            string data = DateTime.Today.Date.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();

            this.Text = $"Abertura do Caixa - Data: {data} - Hora: {hora}";
        }

        private void switchZerado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switchSaldoAnterior.Checked = false;
            }
        }

        private void switchSaldoAnterior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switchZerado.Checked = false;
            }
        }
    }
}
