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

                int total = cboProfessor.Items.Count;

                if (total >= 5)
                {
                    cboProfessor.DropDownStyle = ComboBoxStyle.DropDown;

                    cboProfessor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cboProfessor.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
                else
                {
                    cboProfessor.DropDownStyle = ComboBoxStyle.DropDownList;

                    cboProfessor.AutoCompleteMode = AutoCompleteMode.None;
                    cboProfessor.AutoCompleteSource = AutoCompleteSource.None;
                }
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

            DataGridViewUtils.HandButton(dtgModalidades, "btnEditar", "btnExcluir");

            CursorUtils.HandButton(this);
            CursorUtils.HandToolStripButton(toolStrip1);

            txtNome.Focus();
            rbModalidade.TabStop = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCod.Text == "0")
                {
                    novaModalidade.Salvar(txtNome.Text, Convert.ToDecimal(txtMensalidade.Text), Convert.ToInt32(cboProfessor.SelectedValue));

                    MessageBox.Show("Modalidade salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novaModalidade.Alterar(Convert.ToInt32(txtCod.Text), txtNome.Text, Convert.ToDecimal(txtMensalidade.Text), Convert.ToInt32(cboProfessor.SelectedValue));
                    MessageBox.Show("Modalidade alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ListarModalidades();
                Limpar(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar modalidade: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgModalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgModalidades.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    var row = dtgModalidades.Rows[e.RowIndex];

                    if (row?.DataBoundItem is not DataRowView drv) return;

                    foreach (Control c in this.Controls)
                    {
                        if (c.Tag is not string tag) continue;
                        if (drv.DataView?.Table?.Columns.Contains(tag) == false) continue;

                        if (c is TextBox || c is ComboBox)
                        {
                            c.Text = drv[tag].ToString();
                        }
                    }
                }
                else if (dtgModalidades.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                    MessageBox.Show("Deseja realmente excluir essa modalidade?", "Exclusão de modalidade",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novaModalidade.Excluir(Convert.ToInt32(dtgModalidades.Rows[e.RowIndex].Cells["ID_MODALIDADE"].Value));
                    MessageBox.Show("Modalidade excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarModalidades();
                    Limpar(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir modalidade: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpar(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt)
                    txt.Text = string.Empty;

                if (c is ComboBox cbo)
                    cbo.SelectedIndex = -1;

                if (c.HasChildren)
                    Limpar(c);
            }

            txtCod.Text = "0";
            txtNome.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtNome.Focus();

            Limpar(this);
        }

        private void cboProfessor_Enter(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)(() =>
            {
                if (cboProfessor.DropDownStyle == ComboBoxStyle.DropDownList)
                    cboProfessor.DroppedDown = true;
            }));
        }
    }
}
