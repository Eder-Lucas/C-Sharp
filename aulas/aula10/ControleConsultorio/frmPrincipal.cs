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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            // Instancia o formulário de médicos e depois o exibe
            frmMedicos novoMedico = new frmMedicos();
            novoMedico.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmPacientes novoPaciente = new frmPacientes();
            novoPaciente.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas novaConsulta = new frmConsultas();
            novaConsulta.ShowDialog();
        }
    }
}
