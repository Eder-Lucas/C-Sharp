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

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            int colunas;

            if(flowLayoutPanel1.Width <= 662)
            {
                colunas = 1;
            }
            else if (flowLayoutPanel1.Width <= 982)
            {
                colunas = 2;
            }
            else
            {
                colunas = 3;
            }

            int larguraCard = (flowLayoutPanel1.ClientSize.Width / colunas) - 30;

            // Debug
            label1.Text = $"Largura do FlowLayoutPanel: {flowLayoutPanel1.ClientSize.Width}, Colunas: {colunas}, Largura do Card: {larguraCard}";

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (flowLayoutPanel1.Width > 350)
                    control.Width = larguraCard;
                else
                    control.Width = 300;
            }
        }
    }
}
