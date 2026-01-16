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

        // Ao clicar no botão de excluir do BindingNavigator
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            ExcluirDados.Excluir(medicoBindingSource, tableAdapterManager, consultasDataSet, this, "médico");
        }

        // Ao clicar no botão de salvar do BindingNavigator
        private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultasDataSet);
        }

        // Quando o form for carregado
        private void frmMedicos_Load(object sender, EventArgs e)
        {
            // Carrega os dados do banco e carrega na memória
            this.medicoTableAdapter.Fill(this.consultasDataSet.Medico);

            // Ativa o ajuste do cursor para os MaskedTextBox
            CursorMaskedTextBox.AjustaCursor(this);
        }
    }
}
