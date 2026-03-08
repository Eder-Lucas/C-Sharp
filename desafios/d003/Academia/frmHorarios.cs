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

                ListarHorarios();
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
                dtgHorarios.DataSource = novoHorario.Listar();

                dtgHorarios.Columns["INICIO"]?.DefaultCellStyle.Format = @"hh\:mm";
                dtgHorarios.Columns["FIM"]?.DefaultCellStyle.Format = @"hh\:mm";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Limpar(Control parent)
        {
            foreach(Control c in parent.Controls)
            {
                if (c is TextBox txt)
                    txt.Clear();
                else if (c is ComboBox cbo)
                    cbo.SelectedIndex = -1;
                else if (c is DateTimePicker dtp)
                    dtp.Value = DateTime.Now;

                idHorario = 0;
            }
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

                if (idHorario == 0)
                {
                    novoHorario.Salvar(idTurma, cboSemana.SelectedIndex, inicio, fim);
                    MessageBox.Show(
                        "Modalidade salva com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    novoHorario.Alterar(idHorario, idTurma, cboSemana.SelectedIndex, inicio, fim);
                    MessageBox.Show(
                        "Modalidade alterada com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                ListarHorarios();
                Limpar(this);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
