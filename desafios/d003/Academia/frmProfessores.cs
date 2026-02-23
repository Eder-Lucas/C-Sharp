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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Professores novoProfessor = new();
                novoProfessor.Salvar(
                    txtNome.Text, 
                    txtEndereco.Text, 
                    txtNum.Text, 
                    txtBairro.Text, 
                    txtCidade.Text, 
                    mtbCep.Text, 
                    mtbCpf.Text, 
                    Convert.ToDecimal(txtSalario.Text), 
                    mtbFone.Text, 
                    txtObservacao.Text
                );

                MessageBox.Show("Professor salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar professor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
