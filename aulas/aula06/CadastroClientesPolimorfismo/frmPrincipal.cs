using System.Configuration;
using System.Drawing;

namespace CadastroClientesPolimorfismo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //quando clicar no botão pessoa física
        private void btnPessoaFisica_Click(object sender, EventArgs e)
        {
            //apenas o painel da pessoa física fica visivel
            painelPessoaFisica.Visible = true;
            painelPessoaJuridica.Visible = false;
        }

        //quando clicar no botão pessoa juridica
        private void btnPessoaJuridica_Click(object sender, EventArgs e)
        {
            //apenas o painel da pessoa jurídica fica visivel
            painelPessoaJuridica.Visible = true;
            painelPessoaFisica.Visible = false;
        }

        //quando clicar no botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Entidade pessoa;

            if (painelPessoaFisica.Visible)
            {
                pessoa = new PessoaFisica
                {
                    Nome = txtNomePessoaFisica.Text,
                    Endereco = txtEnderecoPessoaFisica.Text,
                    Cpf = txtCPF.Text,
                    Rg = txtRG.Text
                };
            }
            else
            {
                pessoa = new PessoaJuridica
                {
                    Nome = txtNomePessoaJuridica.Text,
                    Endereco = txtEnderecoPessoaJuridica.Text,
                    Cnpj = txtCNPJ.Text,
                    Ie = txt_IE.Text
                };

            }

            if (pessoa.ValidacaoErro(out string erro))
            {
                MessageBox.Show(erro, "Erro de validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (pessoa is PessoaFisica)
            {
                pessoa.MostrarDados(txtPessoaFisica);
            }
            else
            {
                pessoa.MostrarDados(txtPessoaJuridica);
            }

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
