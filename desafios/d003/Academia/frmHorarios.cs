using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmHorarios : Form
    {
        private int codigo;
        private string modalidade, turma;

        public frmHorarios(int codigo, string modalidade, string turma)
        {
            InitializeComponent();

            this.codigo = codigo;
            this.modalidade = modalidade;
            this.turma = turma;
        }

        private void frmHorarios_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = $"{modalidade} - turma {turma}";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
