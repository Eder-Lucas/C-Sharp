using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }

        // Cria uma instância da classe Alunos para ser usada em todo o formulário
        private readonly Alunos novoAluno = new();

        // Quando o form é carregado
        private void frmAlunos_Load(object sender, EventArgs e)
        {
            // Configurações do DataGridView
            dtgAlunos.AutoGenerateColumns = false;
            dtgAlunos.EnableHeadersVisualStyles = false;

            dtgAlunos.AllowUserToResizeColumns = false;
            dtgAlunos.AllowUserToResizeRows = false;

            // Carrega os alunos
            ListaAlunos();
        }

        // Método para listar os alunos no DataGridView
        public void ListaAlunos()
        {
            try
            {
                // Carrega os alunos e aplica o estilo zebrado
                dtgAlunos.DataSource = novoAluno.Listar();
                DataGridViewUtils.EstiloZebrado(dtgAlunos);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Abre o formulário de controle de alunos ao clicar no botão "Adicionar"
        private void btnAdicionar_Click(object sender, EventArgs e) => new frmControleAlunos(this).ShowDialog();

        // Pesquisa os alunos conforme o texto digitado e o critério selecionado (nome ou CPF)
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbNome.Checked)
                    dtgAlunos.DataSource = novoAluno.PesquisaNome(txtPesquisa.Text);                
                else              
                    dtgAlunos.DataSource = novoAluno.PesquisaCpf(txtPesquisa.Text);               
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Ao dar um duplo clique em um aluno no DataGridView
        private void dtgAlunos_DoubleClick(object sender, EventArgs e)
        {
            // Executa o método ExibirAluno do frmControleAlunos, passando o dtgAlunos como parâmetro
            // abre o form logo após isso
            using frmControleAlunos controleAlunos = new(this);

            // Cria uma instância do frmControleAlunos passando o form atual
            // Permite que o formulário frmControleAlunos acesse os métodos e dados do frmAlunos
            controleAlunos.ExibirAluno(dtgAlunos);
            controleAlunos.ShowDialog();         
        }
    }
}
