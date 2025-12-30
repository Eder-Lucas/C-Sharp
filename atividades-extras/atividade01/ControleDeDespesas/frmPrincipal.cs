using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeDespesas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //botão salvar
        private void contasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.despesasDataSet);

            //atualiza a exibição dos dados na tela
            this.contasTableAdapter.Fill(this.despesasDataSet.Contas);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'despesasDataSet.Contas'. Você pode movê-la ou removê-la conforme necessário.
            this.contasTableAdapter.Fill(this.despesasDataSet.Contas);

        }
    }
}
