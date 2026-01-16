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

        // Ao clicar no botão de excluir do BindingNavigator
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            ExcluirDados.Excluir(consultasBindingSource, tableAdapterManager, consultasDataSet, this, "consulta");
        }

        // Ao clicar no botão de salvar do BindingNavigator
        private void consultasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultasDataSet);
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            // Carrega os dados do banco e carrega na memória
            this.pacienteTableAdapter.Fill(this.consultasDataSet.Paciente);
            this.medicoTableAdapter.Fill(this.consultasDataSet.Medico);
            this.consultasTableAdapter.Fill(this.consultasDataSet.Consultas);
        }
    }
}
