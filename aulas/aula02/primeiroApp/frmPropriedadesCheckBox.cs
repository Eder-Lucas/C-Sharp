using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroApp
{
    public partial class frmPropriedadesCheckBox : Form
    {
        public frmPropriedadesCheckBox()
        {
            InitializeComponent();
        }

        //Evento que verifica se o checkBox está marcado ou desmarcado
        private void chkPessoaFisica_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPessoaFisica.Checked == true) //Se o checkbox pessoa fisica tiver marcado
            {
                pnlPessoaFisica.Visible = true; //O panel é exibido
            }
            else                                //Senão tiver marcado
            {
                pnlPessoaFisica.Visible = false; //O panel ficará oculto
            }
        }

        //Verifica o campo de pessoa juridica
        private void chkPessoaJuridica_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPessoaJuridica.Checked == true) //Se o checkbox pessoa juridica tiver marcado
            {
                pnlPessoaJuridica.Visible = true; //O panel é exibido
            }
            else                                  //Senão tiver marcado
            {
                pnlPessoaJuridica.Visible = false; //O panel ficará oculto
            }
        }
    }
}
