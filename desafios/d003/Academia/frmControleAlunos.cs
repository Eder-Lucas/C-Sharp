using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmControleAlunos : Form
    {
        readonly frmAlunos formulario;

        public frmControleAlunos(frmAlunos formulario)
        {
            InitializeComponent();

            this.formulario = formulario;
        }

        private int idAluno = 0;
        private int idMatricula = 0;
        private readonly Alunos novoAluno = new();
        private readonly Turmas novaTurma = new();
        private readonly Matriculas novaMatricula = new();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var sexo = cboSexo.SelectedIndex == 0 ? "M" : "F";
                bool novo = idAluno == 0;

                ValidaCampos(tabPageCadastro);

                novoAluno.Salvar(idAluno, txtNome.Text, txtEndereco.Text, txtBairro.Text, txtNumero.Text, txtCidade.Text, mtbCep.Text, mtbCpf.Text, mtbTel.Text, sexo, txtObs.Text);

                if (novo)
                {
                    MessageBox.Show(
                    "Aluno salvo com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    bool matricula = MessageBox.Show(
                        "Deseja realizar a matrícula do aluno agora?",
                        "Realizar matrícula?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes;

                    if (matricula) tcAluno.SelectedTab = tabPageMatricula;

                    ListaUltimoAluno();
                }
                else
                {
                    MessageBox.Show(
                    "Aluno alterado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }

                Limpar(tabPageCadastro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar informações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmControleAlunos_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario.ListaAlunos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgTurmasCadastradas.CurrentRow == null || dtgTurmasCadastradas.CurrentRow.Index < 0) return;

                var linha = dtgTurmasCadastradas.Rows[dtgTurmasCadastradas.CurrentRow.Index];
                if (linha?.DataBoundItem is not DataRowView drv) return;

                int idTurma = Convert.ToInt32(drv["ID_TURMA"]);
                int idAluno = Convert.ToInt32(txtCodAluno.Text);
                DateTime venc = dtpVencimento.Value;

                bool novo = idMatricula == 0;

                DataTable dadosTabela = novaMatricula.RetornarTurmasMatriculadas(idAluno);

                novaMatricula.Salvar(idMatricula, idAluno, idTurma, venc, true);

                if (novo)
                {
                    MessageBox.Show(
                    "Aluno matrículado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                    "Matrícula alterada com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }

                ListarMatriculas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar matrícula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidaCampos(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text) && txt.Name != "txtObs")
                        throw new Exception("Preencha todos os campos corretamente!");
                }

                if (c is MaskedTextBox mtb)
                {
                    if (!mtb.MaskFull)
                        throw new Exception("Preencha todos os campos corretamente!");
                }

                if (c is ComboBox cbo)
                {
                    if (cbo.SelectedIndex == -1)
                        throw new Exception("Preencha todos os campos corretamente!");
                }

                if (c.HasChildren)
                    ValidaCampos(c);
            }
        }

        private void ListaUltimoAluno()
        {
            try
            {
                DataTable dadosTabela = new();
                dadosTabela = novoAluno.Listar();

                txtCodAluno.Text = dadosTabela.Rows[0]["ID_ALUNO"].ToString();
                txtNomeAluno.Text = dadosTabela.Rows[0]["NOME_ALUNO"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao listar aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaTurmas()
        {
            try
            {
                dtgTurmasCadastradas.DataSource = novaTurma.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao listar turmas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherCampos(Control parent, DataRowView drv)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.HasChildren)
                    PreencherCampos(c, drv);

                if (c.Tag is not string tag) continue;
                if (drv.DataView?.Table?.Columns.Contains(tag) == false) continue;

                if (c is TextBox || c is MaskedTextBox)
                    c.Text = drv[tag].ToString();
            }
        }

        public void ExibirAluno(DataGridView aluno)
        {
            try
            {
                if (aluno.CurrentRow == null || aluno.CurrentRow.Index < 0) return;

                var linha = aluno.Rows[aluno.CurrentRow.Index];

                if (linha?.DataBoundItem is not DataRowView drv) return;

                this.Text = $"SCA - Controle de Alunos :: {drv["NOME_ALUNO"]} ::";

                PreencherCampos(this, drv);

                cboSexo.SelectedIndex = drv["SEXO"].ToString() == "M" ? 0 : 1;
                idAluno = Convert.ToInt32(drv["ID_ALUNO"]);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Limpar(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt)
                    txt.Clear();
                else if (c is MaskedTextBox mtb)
                    mtb.Clear();

                if (c.HasChildren)
                    Limpar(c);
            }

            idAluno = 0;
            txtCod.Text = "0";
            cboSexo.SelectedIndex = -1;
        }

        public void ListarMatriculas()
        {
            try
            {
                int idAluno = Convert.ToInt32(txtCodAluno.Text);

                DataTable dadosTabela = novaMatricula.RetornarMatriculas(idAluno);
                dtgMatricula.DataSource = dadosTabela;

                dtgMatricula.DataSource = novaMatricula.RetornarTurmasMatriculadas(idAluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao listar matrículas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmControleAlunos_Load(object sender, EventArgs e)
        {
            dtgMatricula.AutoGenerateColumns = false;
            dtgTurmasCadastradas.AutoGenerateColumns = false;

            ListaTurmas();
            ListarMatriculas();

            DataGridViewUtils.EstiloZebrado(dtgMatricula, dtgTurmasCadastradas);
        }
    }
}
