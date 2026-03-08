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

            DataGridViewUtils.HandButton(dtgTurmas, "btnEditar", "btnExcluir", "btnHora");

            CursorUtils.HandButton(this);
            CursorUtils.HandToolStripButton(toolStrip1);
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

                if (total >= 4)
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

        private void Limpar(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox || c is ComboBox)
                    c.Text = string.Empty;

                if (c.HasChildren)
                    Limpar(c);

                txtCod.Text = "0";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCod.Text == "0")
                {
                    novaTurma.Salvar(Convert.ToInt32(cboModalidade.SelectedValue), Convert.ToInt32(txtAluno.Text), Convert.ToInt32(txtTurma.Text));

                    MessageBox.Show("Turma salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novaTurma.Alterar(Convert.ToInt32(txtCod.Text), Convert.ToInt32(cboModalidade.SelectedValue), Convert.ToInt32(txtAluno.Text), Convert.ToInt32(txtTurma.Text));

                    MessageBox.Show("Turma alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                ListarTurmas();
                Limpar(panel1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar turmas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtTurma.Focus();
        }

        private void dtgTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var coluna = dtgTurmas.Columns[e.ColumnIndex].Name;
                var linha = dtgTurmas.Rows[e.RowIndex];

                if (linha?.DataBoundItem is not DataRowView drv) return;

                // ============== BOTÃO EDITAR ==============
                if (coluna == "btnEditar")
                {
                    foreach (Control c in panel1.Controls)
                    {
                        if (c.Tag is not string tag) continue;
                        if (drv.DataView?.Table?.Columns.Contains(tag) == false) continue;

                        if (c is TextBox || c is ComboBox)
                            c.Text = drv[tag].ToString();
                    }
                }

                // ============== BOTÃO EXCLUIR ==============
                else if (coluna == "btnExcluir")
                {
                    if (MessageBox.Show(
                        "Deseja realmente excluir essa modalidade?",
                        "Exclusão de modalidade",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) != DialogResult.Yes)
                        return;

                    novaTurma.Excluir(Convert.ToInt32(drv["ID_TURMA"]));

                    MessageBox.Show(
                        "Modalidade excluída com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ListarTurmas();
                    Limpar(panel1);
                }

                // ============== BOTÃO HORÁRIOS ==============
                else if (coluna == "btnHora")
                {
                    if (MessageBox.Show(
                        "Deseja cadastrar horários para esta turma?",
                        "Cadastrar Horários",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                        return;

                    using frmHorarios frm = new frmHorarios(
                        Convert.ToInt32(drv["ID_TURMA"]),
                        Convert.ToString(drv["NOME_MODALIDADE"])!,
                        Convert.ToString(drv["NUMERO_TURMA"])!
                    );

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir modalidade: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
