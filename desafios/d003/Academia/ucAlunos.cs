using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    public partial class ucAlunos : UserControl
    {
        public ucAlunos()
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
        private void btnAdicionar_Click(object sender, EventArgs e) => Navegacao.AbrirUc(new ucControleAlunos(this));

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
            // Executa o método ExibirAluno do ucControleAlunos, passando o dtgAlunos como parâmetro
            // abre o form logo após isso
            ucControleAlunos controleAlunos = new(this);

            // Cria uma instância do ucControleAlunos passando o form atual
            // Permite que o formulário ucControleAlunos acesse os métodos e dados do ucAlunos
            controleAlunos.ExibirAluno(dtgAlunos);
            Navegacao.AbrirUc(controleAlunos);
        }
    }
}
