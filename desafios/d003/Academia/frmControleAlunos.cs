using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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

        // Quando o form é carregado
        private void frmControleAlunos_Load(object sender, EventArgs e)
        {
            // Configura os DataGridViews para não gerar colunas automaticamente
            dtgMatricula.AutoGenerateColumns = false;
            dtgTurmas.AutoGenerateColumns = false;
            dtgTurmasCadastradas.AutoGenerateColumns = false;

            // Associa o evento genérico ao CellFormatting de ambos os DataGridViews
            dtgTurmas.CellFormatting += FormataGrid;
            dtgMatricula.CellFormatting += FormataGrid;

            // Lista os dados para disparar os eventos, aplicando a formatação visual
            ListarMatriculas();
            ListaTurmas();

            // Aplica o estilo zebrado para melhor visualização
            DataGridViewUtils.EstiloZebrado(dtgMatricula, dtgTurmasCadastradas);
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

                this.Text = $"SCA - Controle de Alunos :: {txtNome.Text} ::";
                txtNomeAluno.Text = txtNome.Text;
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
                // Valida campos comuns
                ValidaCampos(tabPageMatricula);

                // Obtém os dados necessários para inclusão
                var (idTurma, idAluno, idMatricula, situacao, venc) = ObterDadosInclusao();

                // Valida as regras de negócio específicas para matrícula
                if (!ValidaRegrasInclusao(situacao, venc, idMatricula, idTurma, idAluno)) return;

                // Salva a nova matrícula
                IncluirMatricula(idAluno, idTurma, venc, situacao);

                // Atualiza a interface
                ListaTurmas();
                ListarMatriculas();
                PreencherCampos(tabPageMatricula, dtgMatricula);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar matrícula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaRegrasInclusao(bool situacao, DateTime venc, int idMatricula, int idTurma, int idAluno)
        {
            if (TratarMatriculaExistente(idAluno, idTurma, idMatricula)) return false;

            if (!situacao)
            {
                MessageBox.Show(
                "Não é possível criar uma matrícula INATIVA. Por favor, ATIVE a matrícula após criá-la.",
                "Situação inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;
            }

            if (venc.Date <= DateTime.Today)
            {
                MessageBox.Show(
                "A data de vencimento não pode ser anterior ou igual a data atual.",
                "Data inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void IncluirMatricula(int idAluno, int idTurma, DateTime venc, bool situacao)
        {
            int idMatricula = 0;
            novaMatricula.Salvar(idMatricula, idAluno, idTurma, venc, situacao);

            MessageBox.Show(
                "Aluno matrículado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private (int idTurma, int idAluno, int idMatricula, bool situacao, DateTime venc) ObterDadosInclusao()
        {
            int idTurma = Convert.ToInt32(dtgTurmasCadastradas.CurrentRow?.Cells["ID_TURMA"].Value);
            int idAluno = Convert.ToInt32(txtCodAluno.Text);
            int idMatricula = Convert.ToInt32(dtgMatricula.CurrentRow?.Cells["ID_MATRICULA"].Value ?? 0);
            bool situacao = chkSituacao.Checked;
            DateTime venc = dtpVencimento.Value;
            return (idTurma, idAluno, idMatricula, situacao, venc);
        }

        private bool TratarMatriculaExistente(int idAluno, int idTurma, int idMatricula)
        {
            if (novaMatricula.ExisteMatriculaAtiva(idAluno, idTurma))
            {
                MessageBox.Show(
                "Este aluno já possui uma matrícula ativa para esta turma!",
                "Matrícula existente", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Warning);
                return true;
            }

            if (novaMatricula.ExisteMatriculaInativa(idAluno, idTurma))
            {
                bool reativar = MessageBox.Show(
                    "Este aluno já possui uma matrícula para esta turma, porém INATIVA. Deseja reativá-la?",
                    "Reativar matrícula?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes;

                if (!reativar) return true;

                novaMatricula.Salvar(idMatricula, idAluno, idTurma, dtpVencimento.Value, true);

                MessageBox.Show(
                "Matrícula reativada com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                ListarMatriculas();
                PreencherCampos(tabPageMatricula, dtgMatricula);
                return true;
            }

            return false;
        }

        private (int idTurma, int idAluno, int idMatricula, bool situacao, DateTime venc) ObterDadosAlteracao()
        {
            int idTurma = Convert.ToInt32(dtgMatricula.CurrentRow?.Cells["ID_TURMA1"].Value);
            int idAluno = Convert.ToInt32(txtCodAluno.Text);
            int idMatricula = Convert.ToInt32(dtgMatricula.CurrentRow?.Cells["ID_MATRICULA"].Value);
            DateTime venc = dtpVencimento.Value;
            bool situacao = chkSituacao.Checked;
            return (idTurma, idAluno, idMatricula, situacao, venc);
        }

        private void AlterarMatricula(int idMatricula, int idAluno, int idTurma, DateTime venc, bool situacao)
        {
            novaMatricula.Salvar(idMatricula, idAluno, idTurma, venc, situacao);

            MessageBox.Show(
            "Matrícula alterada com sucesso!",
            "Sucesso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private bool ValidaRegrasAlteracao(DateTime venc)
        {
            if (venc.Date <= DateTime.Today)
            {
                MessageBox.Show(
                "A data de vencimento não pode ser anterior ou igual a data atual.",
                "Data inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSalvarMatricula_Click(object sender, EventArgs e)
        {
            try
            {   
                // Valida os campos comuns por segurança
                ValidaCampos(tabPageMatricula);

                // Obtém os dados necessários para alteração
                var (idTurma, idAluno, idMatricula, situacao, venc) = ObterDadosAlteracao();

                // Valida as regras de negócio específicas para alteração de matrícula
                if (!ValidaRegrasAlteracao(venc)) return;

                // Salva as alterações da matrícula
                AlterarMatricula(idMatricula, idAluno, idTurma, venc, situacao);

                // Atualiza a interface
                ListarMatriculas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao alterar matrícula", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    if (txt.Name == "txtNumero" && !int.TryParse(txt.Text, out _))
                        throw new Exception("O campo número deve ser preenchido apenas com números!");
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
                int idAluno = Convert.ToInt32(txtCodAluno.Text);

                dtgTurmasCadastradas.DataSource = novaTurma.Listar();
                dtgTurmas.DataSource = novaMatricula.RetornarTurmasMatriculadas(idAluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao listar turmas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherCampos(Control parent, DataGridView dtg)
        {
            if (dtg.CurrentRow?.DataBoundItem is not DataRowView drv) return;

            foreach (Control c in parent.Controls)
            {
                if (c.HasChildren)
                    PreencherCampos(c, dtg);

                if (c.Tag is not string tag) continue;
                if (drv.DataView?.Table?.Columns.Contains(tag) == false) continue;

                var valor = drv[tag];
                if (valor == DBNull.Value) continue;

                if (c is TextBox || c is MaskedTextBox)
                    c.Text = valor.ToString();

                else if (c is CheckBox chk)
                    chk.Checked = Convert.ToBoolean(valor);

                else if (c is DateTimePicker dtp)
                    dtp.Value = Convert.ToDateTime(valor);
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

                PreencherCampos(this, aluno);

                cboSexo.SelectedIndex = drv["SEXO"].ToString() == "M" ? 0 : 1;
                //idAluno = Convert.ToInt32(drv["ID_ALUNO"]);
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

                DataTable dadosTabela = novaMatricula.RetornarTurmasMatriculadas(idAluno);
                dtgMatricula.DataSource = dadosTabela;
                dtgTurmas.DataSource = dadosTabela;

                AtualizarMensagem(dtgMatricula);                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao listar matrículas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarMensagem(DataGridView dtg)
        {
            bool semDados = dtg.Rows.Count == 0;

            lblMensagem.Visible = semDados;
        }

        private void dtgMatricula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var linha = dtgMatricula.Rows[e.RowIndex];

            if (linha?.DataBoundItem is not DataRowView drv) return;

            dtpVencimento.Value = Convert.ToDateTime(drv["VENCIMENTO"]);
            chkSituacao.Checked = Convert.ToBoolean(drv["SITUACAO"]);
        }

        private void FormataGrid(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (sender is not DataGridView dtg) return;
            if (e.ColumnIndex < 0) return;

            var dataColumn = dtg.Columns[e.ColumnIndex].DataPropertyName;

            switch (dataColumn)
            {
                case "SITUACAO":
                    if (e.Value is not bool situacao) return;

                    e.Value = situacao ? "ATIVA" : "INATIVA";
                    e.CellStyle.BackColor = situacao ? Color.LightGreen : Color.LightPink;

                    e.FormattingApplied = true;
                    break;

                case "MENSALIDADE":
                    if (e.Value is not decimal valor) return;

                    e.Value = valor.ToString("C2", new CultureInfo("pt-BR"));

                    e.FormattingApplied = true;
                    break;
            }
        }

        private void btnExcluirMatricula_Click(object sender, EventArgs e)
        {
            int idMatricula = Convert.ToInt32(dtgMatricula.CurrentRow?.Cells["ID_MATRICULA"].Value);
            novaMatricula.Excluir(idMatricula);

            ListarMatriculas();
            ListaTurmas();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idAluno = Convert.ToInt32(txtCodAluno.Text);
            novoAluno.Excluir(idAluno);

            ListarMatriculas();
            Limpar(tcAluno);
        }

        #region 📌 Implementação antiga - controle de situação da matrícula

        /*
        ⚠️ CÓDIGO LEGADO (mantido para estudo)

        CONTEXTO:
        Antes, a formatação da situação (ATIVA / INATIVA) era feita manualmente,
        percorrendo todas as linhas do DataGridView após o carregamento dos dados.

        MOTIVO DA MUDANÇA:
        Substituído por CellFormatting por ser mais eficiente e não exigir loop manual

        ========================================================
         Enum para representar a situação da matrícula
        ========================================================
        
        private enum SituacaoMatricula
        {
            Ativa = 1,
            Inativa = 0
        }

        ========================================================
         Método antigo de formatação manual
        ========================================================

        private void AplicarSituacao(DataGridView dtg, string col, string cellNome)
        {
            foreach (DataGridViewRow row in dtg.Rows)
            {
                var situacao = (SituacaoMatricula)Convert.ToInt32(row.Cells[col].Value);
                var cell = row.Cells[cellNome];

                if (situacao == SituacaoMatricula.Ativa)
                {
                    cell.Value = "ATIVA";
                    cell.Style.BackColor = Color.LightGreen;
                }
                else
                {
                    cell.Value = "INATIVA";
                    cell.Style.BackColor = Color.LightPink;
                }
            }
        }

        ========================================================
         Associação dos eventos (forma antiga)
        ========================================================

        Era necessário aguardar os dados carregarem para aplicar a formatação.

        private void Grid_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is not DataGridView dtg) return;

            if (dtg.Columns.Contains("SITUACAO1"))
                AplicarSituacao(dtgMatricula, "SITUACAO", "SITUACAO1");

            if (dtg.Columns.Contains("SITUACAO2"))
                AplicarSituacao(dtgTurmas, "SITUACAO", "SITUACAO2");
        }

        ========================================================
         MELHORIA IMPLEMENTADA
        ========================================================

        Substituído pelo evento CellFormatting:

        ✔ Não precisa percorrer linhas manualmente
        ✔ Atualiza automaticamente ao renderizar células

        Método atual utilizado:
        → FormataSituacao(object sender, DataGridViewCellFormattingEventArgs e)
        */

        #endregion

    }
}

