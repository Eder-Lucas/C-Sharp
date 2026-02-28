using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmModalidades : Form
    {
        public frmModalidades()
        {
            InitializeComponent();

            dtgModalidades.AutoGenerateColumns = false;
        }

        private readonly Modalidades novaModalidade = new();

        public void CarregarProfessores()
        {
            try
            {
                Professores novoProfessor = new();

                cboProfessor.DataSource = novoProfessor.Listar();
                cboProfessor.DisplayMember = "NOME_PROFESSOR";
                cboProfessor.ValueMember = "ID_PROFESSOR";

                cboProfessor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os professores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarModalidades()
        {
            try
            {
                dtgModalidades.DataSource = novaModalidade.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as modalidades: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmModalidades_Load(object sender, EventArgs e)
        {
            CarregarProfessores();
            ListarModalidades();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                novaModalidade.Salvar(txtNome.Text, Convert.ToDecimal(txtMensalidade.Text), Convert.ToInt32(cboProfessor.SelectedValue));

                MessageBox.Show("Modalidade salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarModalidades();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a Modalidade: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
