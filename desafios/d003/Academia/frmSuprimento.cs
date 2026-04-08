using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmSuprimento : Form
    {
        int idMensalidade;
        string valor;
        frmControleAlunos frmControleAlunos;

        public frmSuprimento(int idMensalidade, decimal valor, frmControleAlunos frmControleAlunos)
        {
            InitializeComponent();

            this.idMensalidade = idMensalidade;
            this.valor = valor.ToString("c");
            txtDinheiro.Text = this.valor;
            this.frmControleAlunos = frmControleAlunos;
        }

        private readonly Caixa novoCaixa = new();
        private readonly Mensalidades novaMensalidade = new();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var forma = cboFormaPagamento.SelectedIndex.ToString();
            novoCaixa.SalvarTransacao();
        }
    }
}
