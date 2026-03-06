using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmTurmas : Form
    {
        public frmTurmas()
        {
            InitializeComponent();

            dtgTurmas.AutoGenerateColumns = false;
        }

        private void frmTurmas_Load(object sender, EventArgs e)
        {
            CarregarModalidades();
            ListarTurmas();
        }

        private readonly Turmas novaTurma = new();

        public void CarregarModalidades()
        {
            try
            {
                Modalidades novaModalidade = new();

                cboModalidade.DataSource = novaModalidade.Listar();
                cboModalidade.DisplayMember = "NOME_MODALIDADE";
                cboModalidade.ValueMember = "ID_MODALIDADE";

                cboModalidade.SelectedIndex = -1;

                int total = cboModalidade.Items.Count;

                if (total >= 5)
                {
                    cboModalidade.DropDownStyle = ComboBoxStyle.DropDown;

                    cboModalidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cboModalidade.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
                else
                {
                    cboModalidade.DropDownStyle = ComboBoxStyle.DropDownList;

                    cboModalidade.AutoCompleteMode = AutoCompleteMode.None;
                    cboModalidade.AutoCompleteSource = AutoCompleteSource.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as modalidades: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTurmas()
        {
            try
            {
                dtgTurmas.DataSource = novaTurma.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar turmas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                novaTurma.Salvar(Convert.ToInt32(cboModalidade.SelectedValue), Convert.ToInt32(txtAluno.Text), Convert.ToInt32(txtTurma.Text));
                MessageBox.Show("Turma salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarTurmas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar turmas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtTurma.Focus();
        }
    }
}
