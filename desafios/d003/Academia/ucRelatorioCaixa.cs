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
                Panel card = new Panel();
                card.Width = 100;
                card.Height = 50;

                Label nome = new Label();
                nome.Text = $"caixa {row["ID_CAIXA"]}";

                card.Controls.Add(nome);

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void ucRelatorioCaixa_Load(object sender, EventArgs e)
        {
            Carregar();
        }
    }
}
