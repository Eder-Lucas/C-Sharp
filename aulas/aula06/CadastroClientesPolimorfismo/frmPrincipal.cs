using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace CadastroClientesPolimorfismo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //quando clicar no bot�o pessoa f�sica
        private void btnPessoaFisica_Click(object sender, EventArgs e)
        {
            //apenas o painel da pessoa f�sica fica visivel
            painelPessoaFisica.Visible = true;
            painelPessoaJuridica.Visible = false;
        }

        //quando clicar no bot�o pessoa juridica
        private void btnPessoaJuridica_Click(object sender, EventArgs e)
        {
            //apenas o painel da pessoa jur�dica fica visivel
            painelPessoaJuridica.Visible = true;
            painelPessoaFisica.Visible = false;
        }

        //quando clicar no bot�o salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //usando polimorfismo
            //Entidade � a class pai | pessoa � a vari�vel
            //a vari�vel pode referenciar qualquer objeto que seja do tipo Entidade ou herde dela
            Entidade pessoa;

            //se o painel pessoa fisica tiver visivel
            if (painelPessoaFisica.Visible)
            {
                //usando a vari�vel para criar um objeto novo do tipo pessoa fisica
                pessoa = new PessoaFisica
                {
                    Nome = txtNomePessoaFisica.Text,
                    Endereco = txtEnderecoPessoaFisica.Text,
                    Cpf = txtCPF.Text,
                    Rg = txtRG.Text
                };
            }

            //se o painel pessoa juridica tiver visivel
            else
            {
                //usa a vari�vel para criar um novo objeto do tipo pessoa juridica
                pessoa = new PessoaJuridica
                {
                    Nome = txtNomePessoaJuridica.Text,
                    Endereco = txtEnderecoPessoaJuridica.Text,
                    Cnpj = txtCNPJ.Text,
                    Ie = txt_IE.Text
                };
            }

            //chama a valida��o da vari�vel entidade
            if (pessoa.ValidacaoErro(out string erro))
            {
                MessageBox.Show(erro, "Erro de valida��o",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //chama o met�do para mostrar os dados no txt
            switch (pessoa)
            {
                //caso pessoa for refer�nciado como fisica ou juridica
                case PessoaFisica pf:                    
                    pf.MostrarDados(txtPessoaFisica);
                    break;

                case PessoaJuridica pj:
                    pj.MostrarDados(txtPessoaJuridica);
                    break;

                //caso tenha um tipo desconchecido exibe um erro
                default:
                    MessageBox.Show("Tipo de pessoa desconhecido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            /*
            --- OUTRA FORMA DE MOSTRAR OS DADOS ---
            if (pessoa is PessoaFisica)
            {
                pessoa.MostrarDados(txtPessoaFisica);
            }
            else
            {
                pessoa.MostrarDados(txtPessoaJuridica);
            }
            */

            //ao final limpa todos os txt
            Limpar(this);
        }

        public void Limpar(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt && txt.Name != "txtPessoaFisica" && txt.Name != "txtPessoaJuridica")
                {
                    txt.Clear();
                }
                else if (c.HasChildren)
                {
                    Limpar(c);
                }
            }
        }
    }
}
