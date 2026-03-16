using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }

        private readonly Alunos novoAluno = new();

        private void btnAdicionar_Click(object sender, EventArgs e) => new frmControleAlunos().ShowDialog();

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbNome.Checked)
                {
                    dtgAlunos.DataSource = novoAluno.PesquisaNome(txtPesquisa.Text);
                }
                else
                {
                    dtgAlunos.DataSource = novoAluno.PesquisaCpf(txtPesquisa.Text);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ListaAlunos()
        {
            try
            {
                dtgAlunos.DataSource = novoAluno.Listar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            dtgAlunos.AutoGenerateColumns = false;
            dtgAlunos.EnableHeadersVisualStyles = false;
            dtgAlunos.AllowUserToResizeColumns = false;
            dtgAlunos.AllowUserToResizeRows = false;

            ListaAlunos();
            DataGridViewUtils.EstiloZebrado(dtgAlunos);
        }

        private void frmAlunos_Enter(object sender, EventArgs e)
        {
            ListaAlunos();
        }

        private void dtgAlunos_DoubleClick(object sender, EventArgs e)
        {
            DataGridView aluno = dtgAlunos.Rows[dtgAlunos.CurrentRow.Index].DataGridView;

            frmControleAlunos controleAlunos = new();

            controleAlunos.ExibirAluno(aluno);
            controleAlunos.ShowDialog();
        }
    }
}
