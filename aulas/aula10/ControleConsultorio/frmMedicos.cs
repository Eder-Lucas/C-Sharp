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
    public partial class frmMedicos : Form
    {
        public frmMedicos()
        {
            InitializeComponent();
        }

        private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultasDataSet);

        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultasDataSet.Medico'. Você pode movê-la ou removê-la conforme necessário.
            this.medicoTableAdapter.Fill(this.consultasDataSet.Medico);

        }
    }
}
