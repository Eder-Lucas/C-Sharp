using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void consultasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultasDataSet);//faz a atualização dos dados no banco de dados

            //atualiza a exibição dos dados na tela
            this.consultasTableAdapter.Fill(this.consultasDataSet.Consultas);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultasDataSet.Consultas'. Você pode movê-la ou removê-la conforme necessário.
            this.consultasTableAdapter.Fill(this.consultasDataSet.Consultas);

        }

        // Ao clicar no botão Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Verifica qual RadioButton está selecionado e chama o método com a query adequada
            if (rbMedico.Checked)
            {
                // Chama o método para pesquisar por médico passando o texto do TextBox como parâmetro
                // O resultado da consulta é mostrado no DataGridView
                dtgPesquisa.DataSource = consultasTableAdapter.RetornarMedico(txtPesquisa.Text);
            }
            else
            {
                // Chama o método para pesquisar por paciente
                dtgPesquisa.DataSource = consultasTableAdapter.RetornarPaciente(txtPesquisa.Text);
            }
        }
    }
}
