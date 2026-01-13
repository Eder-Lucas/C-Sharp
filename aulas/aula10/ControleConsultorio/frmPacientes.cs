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

        // Ao clicar no botão de salvar do BindingNavigator
        private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultasDataSet);

        }

        // Quando o form for carregado
        private void frmPacientes_Load(object sender, EventArgs e)
        {
            // Carrega os dados do banco e carrega na memória
            this.pacienteTableAdapter.Fill(this.consultasDataSet.Paciente);

            // Ativa o ajuste do cursor para os MaskedTextBox
            CursorMaskedTextBox.AjustaCursor(this);
        }
    }
}
