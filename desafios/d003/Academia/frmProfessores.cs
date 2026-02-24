using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmProfessores : Form
    {
        public frmProfessores()
        {
            InitializeComponent();
        }

        private readonly Professores novoProfessor = new();

        private void frmProfessores_Load(object sender, EventArgs e)
        {
            ListarProfessores();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                novoProfessor.Salvar(
                    txtNome.Text, txtEndereco.Text, txtNum.Text, txtBairro.Text, txtCidade.Text,
                    mtbCep.Text, mtbCpf.Text, Convert.ToDecimal(txtSalario.Text), mtbFone.Text, txtObs.Text
                );

                MessageBox.Show("Professor salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar professor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarProfessores()
        {
            try
            {
                dtgProfessores.DataSource = novoProfessor.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar os dados dos professores: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            foreach (var txt in this.Controls.OfType<TextBox>())
                txt.Text = (txt.Tag?.ToString() == "cod") ? "0" : string.Empty;
        }
    }
}
