using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class ucConfiguracoes : UserControl
    {
        public ucConfiguracoes()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            switchAutoGerar.EnableAnimation = false; // impede carregar a animação ao carregar o form
            switchAutoGerar.Checked = ConfigService.GetBool("GERAR_AUTO_MENSALIDADE"); // Coleta a situação da configuração
            switchAutoGerar.EnableAnimation = true;
        }

        private void switchAutoGerar_CheckedChanged(object sender, EventArgs e)
        {
            ConfigService.Set("GERAR_AUTO_MENSALIDADE", switchAutoGerar.Checked ? "TRUE" : "FALSE");
        }
    }
}
