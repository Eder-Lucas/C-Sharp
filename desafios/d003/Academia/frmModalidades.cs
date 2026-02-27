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
        }

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

        private void frmModalidades_Load(object sender, EventArgs e)
        {
            CarregarProfessores();
        }
    }
}
