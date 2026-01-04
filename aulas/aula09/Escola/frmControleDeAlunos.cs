using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class frmControleDeAlunos : Form
    {
        public frmControleDeAlunos()
        {
            InitializeComponent();
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escolaDataSet);

        }

        private void frmControleDeAlunos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'escolaDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.escolaDataSet.Alunos);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rbAluno.Checked)
            {
                dtgPesquisa.DataSource = alunosTableAdapter.RetornarAluno(txtPesquisa.Text);
            }
            else
            {
                dtgPesquisa.DataSource = alunosTableAdapter.RetornarCurso(txtPesquisa.Text);
            }
        }
    }
}