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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void consultasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultasDataSet);

        }

        private void consultasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultasDataSet);

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultasDataSet.Paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.consultasDataSet.Paciente);
            // TODO: esta linha de código carrega dados na tabela 'consultasDataSet.Medico'. Você pode movê-la ou removê-la conforme necessário.
            this.medicoTableAdapter.Fill(this.consultasDataSet.Medico);
            // TODO: esta linha de código carrega dados na tabela 'consultasDataSet.Consultas'. Você pode movê-la ou removê-la conforme necessário.
            this.consultasTableAdapter.Fill(this.consultasDataSet.Consultas);

        }
    }
}
