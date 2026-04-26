using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmCaixa : Form
    {
        public frmPrincipal formularioPrincipal;
        public frmCaixa(frmPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        private readonly Caixa novoCaixa = new();

        private void btnAbrirCaixa_Click(object sender, EventArgs e) => new frmAberturaCaixa().ShowDialog();

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                bool fechar = MessageBox.Show(
                    "Deseja realmente fechar o caixa?", 
                    "Deseja fechar?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes;

                if (fechar)
                {
                    DataTable dadosCaixa = novoCaixa.Listar();
                    int idCaixa = Convert.ToInt32(dadosCaixa.Rows[0]["ID_CAIXA"]);

                    novoCaixa.AlterarSituacao(idCaixa, false);
                    formularioPrincipal.VerificaSituacaoCaixa();

                    MessageBox.Show("Caixa fechado com sucesso!", "Caixa fechado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
