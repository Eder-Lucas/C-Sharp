using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;

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
            txtNome.Focus();
            rbNome.TabStop = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FormataNomes(txtNome, txtEndereco, txtBairro, txtCidade);

                if (txtCod.Text == "0")
                {
                    novoProfessor.Salvar(
                        txtNome.Text, txtEndereco.Text, txtNum.Text, txtBairro.Text, txtCidade.Text,
                        mtbCep.Text, mtbCpf.Text, Convert.ToDecimal(txtSalario.Text), mtbFone.Text, txtObs.Text
                    );

                    MessageBox.Show("Professor salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novoProfessor.Alterar(
                        Convert.ToInt32(txtCod.Text), txtNome.Text, txtEndereco.Text, txtNum.Text, txtBairro.Text,
                        txtCidade.Text, mtbCep.Text, mtbCpf.Text, Convert.ToDecimal(txtSalario.Text), mtbFone.Text, txtObs.Text
                    );

                    MessageBox.Show("Professor alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimparCampos();
                ListarProfessores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar professor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNome.Focus();
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
                txt.Text = (txt.Tag?.ToString() == "ID_PROFESSOR") ? "0" : string.Empty;

            foreach (var mtb in this.Controls.OfType<MaskedTextBox>())
                mtb.Text = string.Empty;
        }

        // Ao clicar em uma célula do DataGridView
        private void dtgProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se a coluna clicada for a de edição (btnEditar)
            if (dtgProfessores.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                var row = dtgProfessores.Rows[e.RowIndex]; // Pega a linha clicada

                // row?.DataBoundItem: pega o objeto de dados bruto
                // is not DataRowView: checa se esse objeto realmente existe
                // Se a linha for válida, já cria a variável drv do tipo DataRowView
                if (row?.DataBoundItem is not DataRowView drv) return;

                // Verifica cada controle do form
                foreach (Control c in this.Controls)
                {
                    // Ignora controles onde Tag é nulo
                    // Caso seja válido, já cria a variável 'tag' do tipo string
                    if (c.Tag is not string tag) continue;

                    // Ignora se a coluna do DataView não contém a tag do controle
                    if (drv.DataView?.Table?.Columns.Contains(tag) != true) continue;

                    // Se for TextBox ou MaskedTextBox
                    // Preenche o campo com o valor correspondente do DataRowView
                    if (c is TextBox || c is MaskedTextBox)
                    {
                        c.Text = drv[tag].ToString();

                        /* Sem essa lógica, o código ficaria assim para todos os campos:
                            txtCod.Text = dtgProfessores.Rows[e?.RowIndex].Cells["CODIGO"].Value.ToString(); */
                    }
                }
            }
            // Se a coluna clicada for a de exclusão (btnExcluir)
            else if (dtgProfessores.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                     MessageBox.Show("Deseja realmente excluir este professor?", "Exclusão de professor,",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    novoProfessor.Excluir(Convert.ToInt32(dtgProfessores.Rows[e.RowIndex].Cells["ID_PROFESSOR"].Value));

                    MessageBox.Show("Professor excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarProfessores();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir os dados do professor: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método de pesquisa acionado quando o campo é alterado
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbNome.Checked)
                {
                    dtgProfessores.DataSource = novoProfessor.PesquisaNome(txtPesquisa.Text);
                }
                else
                {
                    dtgProfessores.DataSource = novoProfessor.PesquisaCpf(txtPesquisa.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar dados: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método que formata os campos de texto
        private void FormataNomes(params TextBox[] campos)
        {
            string[] preposicoes = { "de", "do", "da", "dos", "das", "e" };

            TextInfo ti = new CultureInfo("pt-BR", false).TextInfo;

            foreach (TextBox txt in campos)
            {
                var palavras = txt.Text
                .Trim()
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select((palavras, index) =>
                {
                    if (index > 0 && preposicoes.Contains(palavras))
                        return palavras;

                    return ti.ToTitleCase(palavras);

                });

                txt.Text = string.Join(' ', palavras);
            }
        }
    }
}
