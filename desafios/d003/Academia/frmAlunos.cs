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
                Estilo();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Estilo()
        {
            var linhas = dtgAlunos.Rows.Count;

            for (int i = 0; i < linhas; i++)
            {
                dtgAlunos.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.White : Color.LightGray;
            }
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            dtgAlunos.AutoGenerateColumns = false;
            dtgAlunos.EnableHeadersVisualStyles = false;
            dtgAlunos.AllowUserToResizeColumns = false;
            dtgAlunos.AllowUserToResizeRows = false;

            ListaAlunos();
        }
    }
}
