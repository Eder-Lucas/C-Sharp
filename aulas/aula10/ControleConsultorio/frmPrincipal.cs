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

        // Ao clicar no botão, abre o formulário correspondente
        private void btnMedicos_Click(object sender, EventArgs e) => AbrirFormulario<frmMedicos>();
        private void btnPacientes_Click(object sender, EventArgs e) => AbrirFormulario<frmPacientes>();
        private void btnConsultas_Click(object sender, EventArgs e) => AbrirFormulario<frmConsultas>();

        // Ao clicar no botão, exibe o painel correspondente
        private void btnPesquisas_Click(object sender, EventArgs e) => MostrarPainel(pnlPesquisa);
        private void btnFechar_Click(object sender, EventArgs e) => MostrarPainel(pnlLogo);

        // Método genérico para abrir formulários
        // Métodos genéricos: não sabe qual tipo vai receber, apenas quando for chamado
        private void AbrirFormulario<T>() where T : Form, new()
        {
            // Garante que o formulário seja fechado após o uso
            // Reduz o risco de vazamento de memória
            // RAM melhor utilizada
            using (T formulario = new T())
            {
                formulario.ShowDialog();
            }
        }

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
