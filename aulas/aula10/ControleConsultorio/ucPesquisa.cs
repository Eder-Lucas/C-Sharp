using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleConsultorio
{
    public partial class ucPesquisa : UserControl
    {
        public ucPesquisa()
        {
            InitializeComponent();
        }

        private void btnPesquisaUC_Click(object sender, EventArgs e)
        {
            dtgConsultas.DataSource = consultasTableAdapter1.retornarConsultas(dtpInicial.Value, dtpFinal.Value);
        }
    }
}
