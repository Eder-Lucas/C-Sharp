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
        public frmControleAlunos()
        {
            InitializeComponent();

            ListaTurmas();
        }

        private int idAluno = 0;
        private readonly Alunos novoAluno = new();
        private readonly Turmas novaTurma = new();

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
    }
}
