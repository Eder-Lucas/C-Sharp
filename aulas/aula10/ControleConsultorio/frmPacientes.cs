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

        /* Sem utilizar a classe ExcluirDados
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir este paciente?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                pacienteBindingSource.RemoveCurrent();

                this.Validate();
                this.pacienteBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.consultasDataSet);

                MessageBox.Show("Registro excluído com sucesso!");
            }
        }
        */

        // Ao clicar no botão de excluir do BindingNavigator
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            ExcluirDados.Excluir(pacienteBindingSource, tableAdapterManager, consultasDataSet, this, "paciente");
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
            FormataCursorMtb.AjustaCursor(this);
        }
    }
}
