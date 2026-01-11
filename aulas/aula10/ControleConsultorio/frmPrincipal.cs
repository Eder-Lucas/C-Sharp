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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private bool pesquisaAberta = false;

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            // Instancia o formulário de médicos e depois o exibe
            frmMedicos novoMedico = new frmMedicos();
            novoMedico.ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes novoPaciente = new frmPacientes();
            novoPaciente.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas novaConsulta = new frmConsultas();
            novaConsulta.ShowDialog();
        }

        private void btnPesquisas_Click(object sender, EventArgs e)
        {           
            if (pesquisaAberta == false)
            {
                pnlConteudo.Visible = true;
                pnlLogo.Visible = false;

                btnFechar.Visible = true;
                pesquisaAberta = true;
            }         
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ucLogo telaLogo = new ucLogo();
            telaLogo.Dock = DockStyle.Fill;
            pnlLogo.Controls.Add(telaLogo);

            ucPesquisa telaPesquisa = new ucPesquisa();
            telaPesquisa.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(telaPesquisa);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (pesquisaAberta == true)
            {
                pnlLogo.Visible = true;
                pnlConteudo.Visible = false;

                btnFechar.Visible = false;
                pesquisaAberta = false;
            }
        }
    }
}
