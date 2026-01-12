using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleConsultorio
{
    public partial class ucPesquisa : UserControl
    {
        public ucPesquisa()
        {
            InitializeComponent();
        }

        private void btnPesquisaUC_Click(object sender, EventArgs e)
        {
            // No banco de dados foi salvo com horas, pois é um datetime
            // Pega somente a data (sem hora)
            // As horas interferem na query
            DateTime dataInicio = dtpInicial.Value.Date;
            DateTime dataFinal = dtpFinal.Value.Date;

            // Verifica se o campo de pesquisa está vazio
            // Se tiver faz a pesquisa somente por data
            if (String.IsNullOrEmpty(txtPesquisa.Text))
            {
                dtgConsultas.DataSource = consultasTableAdapter1.retornarConsultas(dataInicio, dataFinal); 
            }
            // Se o campo de pesquisa tiver algo digitado
            else
            {
                // Faz a consulta (query) conforme o radio button selecionado
                if (rbPaciente.Checked)
                {
                    dtgConsultas.DataSource = consultasTableAdapter1.retornarPaciente(txtPesquisa.Text, dataInicio, dataFinal);
                }
                else if (rbMedico.Checked)
                {
                    dtgConsultas.DataSource = consultasTableAdapter1.retornarMedico(txtPesquisa.Text, dataInicio, dataFinal);
                }
            }
        }
    }
}
