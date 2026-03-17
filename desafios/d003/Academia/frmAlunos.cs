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

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            dtgAlunos.AutoGenerateColumns = false;
            dtgAlunos.EnableHeadersVisualStyles = false;

            dtgAlunos.AllowUserToResizeColumns = false;
            dtgAlunos.AllowUserToResizeRows = false;

            ListaAlunos();
            DataGridViewUtils.EstiloZebrado(dtgAlunos);
        }

        private void btnAdicionar_Click(object sender, EventArgs e) => new frmControleAlunos(this).ShowDialog();

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbNome.Checked)
                    dtgAlunos.DataSource = novoAluno.PesquisaNome(txtPesquisa.Text);                
                else              
                    dtgAlunos.DataSource = novoAluno.PesquisaCpf(txtPesquisa.Text);               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dtgAlunos_DoubleClick(object sender, EventArgs e)
        {
            frmControleAlunos controleAlunos = new(this);

            controleAlunos.ExibirAluno(dtgAlunos);
            controleAlunos.ShowDialog();
        }

        public void ListaAlunos()
        {
            try
            {
                dtgAlunos.DataSource = novoAluno.Listar();
                DataGridViewUtils.EstiloZebrado(dtgAlunos);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
