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

        // Instancia os formulários e depois o exibe
        private void btnMedicos_Click(object sender, EventArgs e)
        {
            using (frmMedicos novoMedico = new frmMedicos())
            {
                novoMedico.ShowDialog();
            }            
        }
        private void btnPacientes_Click(object sender, EventArgs e)
        {
            using (frmPacientes novoPaciente = new frmPacientes())
            {
                novoPaciente.ShowDialog();
            }
        }
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            using (frmConsultas novaConsulta= new frmConsultas())
            {
                novaConsulta.ShowDialog();
            }
        }

        // Ao clicar no botão de pesquisas
        // Exibe o painel de pesquisas
        private void btnPesquisas_Click(object sender, EventArgs e) => MostrarPainel(pnlPesquisa);

        // Ao clicar no botão de fechar
        // Exibe o painel de logo
        private void btnFechar_Click(object sender, EventArgs e) => MostrarPainel(pnlLogo);

        // Método para exibir o painel desejado
        private void MostrarPainel(Panel pnlDesejado)
        {
            // Oculta todos os painéis
            pnlPesquisa.Visible = false;
            pnlLogo.Visible = false;

            // Exibe o painel desejado
            pnlDesejado.Visible = true;

            // Controla a visibilidade do botão Fechar
            btnFechar.Visible = (pnlDesejado == pnlPesquisa);
        }

        // Ao carregar o formulário principal
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Instancia os UserControls de Logo e Pesquisa
            // Adiciona os UserControls de Logo e Pesquisa aos seus respectivos painéis
            // Usa Dock Fill para preencher todo o espaço dos painéis
            ucLogo telaLogo = new ucLogo();
            telaLogo.Dock = DockStyle.Fill;
            pnlLogo.Controls.Add(telaLogo);

            ucPesquisa telaPesquisa = new ucPesquisa();
            telaPesquisa.Dock = DockStyle.Fill;
            pnlPesquisa.Controls.Add(telaPesquisa);
        }
    }
}
