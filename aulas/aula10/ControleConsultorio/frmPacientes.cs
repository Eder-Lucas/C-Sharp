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
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultasDataSet);

        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultasDataSet.Paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.consultasDataSet.Paciente);

        }
    }
}
