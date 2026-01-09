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

        private void AbrirTela(UserControl tela)
        {
            pnlConteudo.Controls.Clear();           
            tela.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(tela);
        }

        private void btnPesquisas_Click(object sender, EventArgs e)
        {           
            if (pesquisaAberta == false)
            {
                ucPesquisa telaPesquisa = new ucPesquisa();
                AbrirTela(telaPesquisa);

                btnFechar.Visible = true;
                pesquisaAberta = true;
            }         
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ucLogo telaInicio = new ucLogo();
            ucPesquisa telaPesquisa = new ucPesquisa();

            pnlConteudo.Controls.Add(telaInicio);
            pnlConteudo.Controls.Add(telaPesquisa);

            telaPesquisa.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (pesquisaAberta == true)
            {
                ucPesquisa tela = new ucPesquisa();
                tela.Visible = false;
                AbrirTela(new ucLogo());

                btnFechar.Visible = false;
                pesquisaAberta = false;
            }
        }
    }
}
