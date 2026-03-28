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
        // Cria uma variável para armazenar a referência do frmAlunos
        readonly frmAlunos formAlunos;

        // Método construtor: Executa sempre quando o formulário é instanciado
        // Este form(frmControleAlunos) é aberto a partir do frmAlunos
        // Então recebemos uma referência do frmAlunos JÁ ABERTO para podermos atualizar seus métodos
        // Não criamos uma nova instância do frmAlunos, pois teriamos DUAS INSTÂNCIAS DIFERENTES
        public frmControleAlunos(frmAlunos formulario)
        {
            InitializeComponent();

            this.formAlunos = formulario; // Armazena a referência do frmAlunos passado como parâmetro
        }

        // Variável para controlar o ID do aluno
        private int idAluno = 0;

        // Cria instâncias das classes Alunos, Turmas e Matriculas para serem usadas em todo o formulário
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

            dtgMatricula.SelectionChanged += CarregarMatriculaAtual;

            // Lista os dados para disparar os eventos, aplicando a formatação visual
            ListarMatriculas();
            ListarTurmas();

            // Aplica o estilo zebrado para melhor visualização
            DataGridViewUtils.EstiloZebrado(dtgMatricula, dtgTurmasCadastradas);
        }

        // Quando o formulário é fechado, lista os alunos novamente no frmAlunos para atualizar a exibição
        private void frmControleAlunos_FormClosed(object sender, FormClosedEventArgs e) => formAlunos.ListaAlunos();

        // Ao clicar no botão "Salvar" na aba de cadastro
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida os campos
                ValidaCampos(tabPageCadastro);

                // Converte o campo sexo para o formato que o banco espera (M ou F)
                var sexo = cboSexo.SelectedIndex == 0 ? "M" : "F";

                // Salva as informações do aluno (tanto para novo cadastro quanto para alteração)
                novoAluno.Salvar(idAluno, txtNome.Text, txtEndereco.Text, txtBairro.Text, txtNumero.Text, txtCidade.Text, mtbCep.Text, mtbCpf.Text, mtbTel.Text, sexo, txtObs.Text);

                // Verifica através da variável global se é um nono cadastro
                bool novo = idAluno == 0;

                // Se for um novo aluno
                if (novo)
                {
                    // Mensagem de sucesso para o usuário
                    MessageBox.Show(
                    "Aluno salvo com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    // Pergunta se o usuário já deseja realizar uma matrícula, salvando a resposta na variável
                    bool matricula = MessageBox.Show(
                        "Deseja realizar a matrícula do aluno agora?",
                        "Realizar matrícula?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes;

                    // Se deseja, troca para a aba de matrículas para facilitar o processo
                    if (matricula) tcAluno.SelectedTab = tabPageMatricula;

                    // Lista os dados do aluno recém cadastrado nos campos da aba matrícula
                    ListaUltimoAluno();
                }
                // Se não for um novo aluno, exibe a mensagem de alteração bem sucedida
                else
                {
                    MessageBox.Show(
                    "Aluno alterado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }

                // Atualiza o título do formulário e o campo de nome na aba de matrícula para refletir as alterações
                this.Text = $"SCA - Controle de Alunos :: {txtNome.Text} ::";
                txtNomeAluno.Text = txtNome.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar informações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ao clicar no botão "Incluir" na aba de matrícula
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida campos comuns
                ValidaCampos(tabPageMatricula);

                // Obtém os dados necessários para inclusão
                var (idTurma, idAluno, idMatricula, situacao, venc, vagas) = ObterDadosInclusao();

                // Valida as regras de negócio específicas para matrícula
                if (!ValidaRegrasInclusao(situacao, venc, idMatricula, idTurma, idAluno, vagas)) return;

                // Salva a nova matrícula
                IncluirMatricula(idAluno, idTurma, venc, situacao);

                // Atualiza a interface
                ListarTurmas();
                ListarMatriculas();
                PreencherCampos(tabPageMatricula, dtgMatricula);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar matrícula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region 📌 Métodos Auxiliares para inclusão de matrícula

        // Obtém os dados necessários para inclusão de matrícula
        // Usando Tupla: permite retornar múltiplos valores de forma organizada
        private (int idTurma, int idAluno, int idMatricula, bool situacao, DateTime venc, int vagas) ObterDadosInclusao()
        {
            // Coleta os dados já convertidos
            int idTurma = Convert.ToInt32(dtgTurmasCadastradas.CurrentRow?.Cells["ID_TURMA"].Value);
            int idAluno = Convert.ToInt32(txtCodAluno.Text);
            int idMatricula = Convert.ToInt32(dtgMatricula.CurrentRow?.Cells["ID_MATRICULA"].Value ?? 0);
            bool situacao = chkSituacao.Checked;
            DateTime venc = dtpVencimento.Value;
            int vagas = Convert.ToInt32(dtgTurmasCadastradas.CurrentRow?.Cells["VAGAS"].Value);

            // Retorna os dados para serem usados posteriormente
            return (idTurma, idAluno, idMatricula, situacao, venc, vagas);
        }

        // Valida as regras de negócio para inclusão de matrículas
        private bool ValidaRegrasInclusao(bool situacao, DateTime venc, int idMatricula, int idTurma, int idAluno, int vagas)
        {
            // Trata as situações onde exista alguma matrícula desse aluno para essa turma
            if (TratarMatriculaExistente(idAluno, idTurma, idMatricula)) return false;

            // Verifica se há vagas disponíveis para a turma selecionada
            if (vagas <= 0)
            {
                MessageBox.Show(
                "Não há vagas disponíveis para esta turma. Por favor, escolha outra turma.",
                "Turma lotada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;
            }

            // Não permite criar uma matrícula já inativa, pois isso pode gerar confusão e inconsistências
            if (!situacao)
            {
                MessageBox.Show(
                "Não é possível criar uma matrícula INATIVA. Por favor, ATIVE a matrícula após criá-la.",
                "Situação inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;
            }

            // A data de vencimento deve ser obrigatoriamente futura para evitar confusões e erros de controle
            if (venc.Date <= DateTime.Today)
            {
                MessageBox.Show(
                "A data de vencimento não pode ser anterior ou igual a data atual.",
                "Data inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;
            }

            // Se passou por todas as validações, retorna true para prosseguir o fluxo do código
            return true;
        }

        // Trata os casos onde já exista uma matrícula para o mesmo aluno e turma
        private bool TratarMatriculaExistente(int idAluno, int idTurma, int idMatricula)
        {
            // Se a matrícula existe e está ativa, avisa ao usuário e bloqueia a inclusão
            if (novaMatricula.ExisteMatriculaAtiva(idAluno, idTurma))
            {
                MessageBox.Show(
                "Este aluno já possui uma matrícula ativa para esta turma!",
                "Matrícula existente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return true;
            }

            // Se a matrícula existe mas está inativa, oferece a opção de reativar
            if (novaMatricula.ExisteMatriculaInativa(idAluno, idTurma))
            {
                // Pergunta ao usuário se deseja reativar
                bool reativar = MessageBox.Show(
                    "Este aluno já possui uma matrícula para esta turma, porém INATIVA. Deseja reativá-la?",
                    "Reativar matrícula?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes;

                // Se o usuário escolher não reativar, bloqueia a inclusão
                if (!reativar) return true;

                // Reativa a matrícula existente
                novaMatricula.Salvar(idMatricula, idAluno, idTurma, dtpVencimento.Value, true);

                // Mensagem de sucesso
                MessageBox.Show(
                "Matrícula reativada com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                // Atualiza a interface para refletir a reativação
                ListarMatriculas();
                PreencherCampos(tabPageMatricula, dtgMatricula);

                // Retorna true para bloquear a inclusão original, pois já reativamos a matrícula existente
                return true;
            }

            // Se não existe nenhuma matrícula desse aluno nessa turma, permite a inclusão normalmente
            return false;
        }

        // Método que incluir a matrícula no banco de dados e exibe a mensagem de sucesso
        private void IncluirMatricula(int idAluno, int idTurma, DateTime venc, bool situacao)
        {
            int idMatricula = 0; // Para inclusão, o ID é sempre 0
            novaMatricula.Salvar(idMatricula, idAluno, idTurma, venc, situacao);

            MessageBox.Show(
                "Aluno matrículado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        #endregion

        #region 📌 Métodos Auxiliares para alteração da matrícula

        // Obtém os dados necessários para alteração de matrícula
        private (int idTurma, int idAluno, int idMatricula, bool situacao, DateTime venc) ObterDadosAlteracao()
        {
            int idTurma = Convert.ToInt32(dtgMatricula.CurrentRow?.Cells["ID_TURMA1"].Value);
            int idAluno = Convert.ToInt32(txtCodAluno.Text);
            int idMatricula = Convert.ToInt32(dtgMatricula.CurrentRow?.Cells["ID_MATRICULA"].Value);
            DateTime venc = dtpVencimento.Value;
            bool situacao = chkSituacao.Checked;
            return (idTurma, idAluno, idMatricula, situacao, venc);
        }

        // Método que valida as regras de negócio para alteração de matrícula
        private bool ValidaRegrasAlteracao(DateTime venc)
        {
            // A data de vencimento deve ser obrigatoriamente maior que a data de hoje
            if (venc.Date <= DateTime.Today)
            {
                MessageBox.Show(
                "A data de vencimento não pode ser anterior ou igual a data atual.",
                "Data inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;
            }

            // Se passou por todas as validações, retorna true para prosseguir o fluxo do código
            return true;
        }

        // Método que salva as alterações da matrícula no banco de dados e exibe a mensagem de sucesso
        private void AlterarMatricula(int idMatricula, int idAluno, int idTurma, DateTime venc, bool situacao)
        {
            novaMatricula.Salvar(idMatricula, idAluno, idTurma, venc, situacao);

            MessageBox.Show(
            "Matrícula alterada com sucesso!",
            "Sucesso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        #endregion

        // Ao clicar no botão "Salvar" na aba de matrícula, realiza a alteração da matrícula selecionada
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
                ListarTurmas();
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

        private void ListarTurmas()
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

        private void CarregarMatriculaAtual(object? sender, EventArgs e)
        {
            if (dtgMatricula.CurrentRow == null || dtgMatricula.CurrentRow.Index < 0) return;

            if (dtgMatricula.CurrentRow.DataBoundItem is not DataRowView drv) return;

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
            ListarTurmas();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idAluno = Convert.ToInt32(txtCodAluno.Text);
            novoAluno.Excluir(idAluno);

            ListarMatriculas();
            Limpar(tcAluno);
        }

        private void dtgTurmasCadastradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var coluna = dtgTurmasCadastradas.Columns[e.ColumnIndex].Name;
            var linha = dtgTurmasCadastradas.Rows[e.RowIndex];

            if (linha?.DataBoundItem is not DataRowView drv) return;

            if (coluna == "btnHora")
            {
                using frmHorarios frm = new frmHorarios(
                    Convert.ToInt32(drv["ID_TURMA"]),
                    Convert.ToString(drv["NOME_MODALIDADE"])!,
                    Convert.ToString(drv["NUMERO_TURMA"])!
                );

                frm.ShowDialog();   
            }
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

