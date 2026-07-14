using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class CardCaixa : UserControl
    {
        public CardCaixa()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdCaixa { get; set; }

        public void Configurar(string nome, decimal saldo, bool situacao)
        {
            lblCaixa.Text = nome;
            lblSaldo.Text = saldo.ToString("C");
            lblSituacao.Text = situacao ? "Aberto" : "Fechado";
        }
    }
}
