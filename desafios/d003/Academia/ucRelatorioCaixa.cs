using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class ucRelatorioCaixa : UserControl
    {
        public ucRelatorioCaixa()
        {
            InitializeComponent();
        }

        private readonly Caixa novoCaixa = new();

        private void Carregar()
        {
            DataTable caixa = novoCaixa.ListarCaixa();

            foreach (DataRow row in caixa.Rows)
            {
                CardCaixa card = new();
                card.IdCaixa = Convert.ToInt32(row["ID_CAIXA"]);              

                card.Configurar($"Caixa {row["ID_CAIXA"]}", Convert.ToDecimal(row["SALDO_INICIAL"]));

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void ucRelatorioCaixa_Load(object sender, EventArgs e)
        {
            Carregar();
        }
    }
}
