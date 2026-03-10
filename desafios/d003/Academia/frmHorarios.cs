using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmHorarios : Form
    {
        private int idTurma;
        private string modalidade, turma;
        private int idHorario = 0;

        private readonly Horarios novoHorario = new();

        public frmHorarios(int idTurma, string modalidade, string turma)
        {
            InitializeComponent();

            this.idTurma = idTurma;
            this.modalidade = modalidade;
            this.turma = turma;
        }

        private void frmHorarios_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = $"{modalidade} - turma {turma}";

                cboSemana.SelectedIndex = 0;

                CursorUtils.HandButton(this);

                dtgHorarios.AutoGenerateColumns = false;
                dtgHorarios.EnableHeadersVisualStyles = false;

                ListarHorarios();

                DataGridViewUtils.AjustaBarraVertical("SEMANA_NOME", dtgHorarios);
                DataGridViewUtils.RemoveOrdenacao(dtgHorarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarHorarios()
        {
            try
            {
                DataTable tabela = novoHorario.Listar(idTurma);

                tabela.Columns.Add("SEMANA_NOME", typeof(string));

                foreach (DataRow linha in tabela.Rows)
                {
                    int dia = Convert.ToInt32(linha["DIA_SEMANA"]);
                    linha["SEMANA_NOME"] = ((NomeSemana)dia).ToString();
                }

                dtgHorarios.DataSource = tabela;

                dtgHorarios.Columns["INICIO"]?.DefaultCellStyle.Format = @"hh\:mm";
                dtgHorarios.Columns["FIM"]?.DefaultCellStyle.Format = @"hh\:mm";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private enum NomeSemana
        {
            Domingo = 1,
            Segunda = 2,
            Terça = 3,
            Quarta = 4,
            Quinta = 5,
            Sexta = 6,
            Sábado = 7
        }

        private void Limpar(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt)
                    txt.Clear();
                else if (c is DateTimePicker dtp)
                    dtp.Value = DateTime.Today;

                if (c.HasChildren)
                    Limpar(c);
            }

            idHorario = 0;
            cboSemana.SelectedIndex = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Limpar(this);          
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan inicio = dtpInicio.Value.TimeOfDay;
                TimeSpan fim = dtpFim.Value.TimeOfDay;

                bool novo = idHorario == 0;

                if (cboSemana.SelectedIndex <= 0)
                {
                    MessageBox.Show(
                    "Selecione um horário para editar",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

                novoHorario.Salvar(idHorario, idTurma, cboSemana.SelectedIndex, inicio, fim);

                if (novo)
                    MessageBox.Show(
                    "Horário salvo com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                else
                    MessageBox.Show(
                    "Horário alterado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ListarHorarios();
                Limpar(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar informações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgHorarios.CurrentRow == null)
            {
                MessageBox.Show(
                "Selecione um horário para editar",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }

            if (dtgHorarios.CurrentRow.DataBoundItem is not DataRowView drv) return;

            idHorario = Convert.ToInt32(drv["ID_HORARIO"]);
            idTurma = Convert.ToInt32(drv["ID_TURMA"]);
            cboSemana.SelectedIndex = Convert.ToInt32(drv["DIA_SEMANA"]);
            dtpInicio.Value = DateTime.Today.Add((TimeSpan)drv["INICIO"]);
            dtpFim.Value = DateTime.Today.Add((TimeSpan)drv["FIM"]);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgHorarios.CurrentRow == null)
                {
                    MessageBox.Show(
                    "Selecione um horário para excluir",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show(
                    "Deseja realmente excluir essa modalidade?",
                    "Exclusão de modalidade",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                idHorario = Convert.ToInt32(dtgHorarios.CurrentRow.Cells["ID_HORARIO"].Value);
                novoHorario.Excluir(idHorario);

                ListarHorarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao excluir horário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
