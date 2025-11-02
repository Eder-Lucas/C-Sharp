using System.Configuration;
using System.Drawing;

namespace CadastroClientesInterfaces
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
            //a variável pessoa referencia qualquer objeto que seja do tipo Pessoa ou herde dela
            Pessoa pessoa;

            //se o painel de pessoa fisica tiver visivel
            if (painelPessoaFisica.Visible)
            {
                //objeto pessoa do tipo PessoaFisica
                pessoa = new PessoaFisica
                {
                    //salva os dados
                    Nome = txtNomePessoaFisica.Text,
                    Endereco = txtEnderecoPessoaFisica.Text,
                    Cpf = txtCPF.Text,
                    Rg = txtRG.Text
                };

                //mostra os dados no txt
                pessoa.MostrarDados(txtPessoaFisica);
            }

            //se o painel de pessoa juridica tiver visivel
            else
            {
                //cria um objeto pessoa do tipo PessoaJuridica
                pessoa = new PessoaJuridica
                {
                    //salva seus dados
                    Nome = txtNomePessoaJuridica.Text,
                    Endereco = txtEnderecoPessoaJuridica.Text,
                    Cnpj = txtCNPJ.Text,
                    Ie = txt_IE.Text
                };

                //mostra os dados no txt
                pessoa.MostrarDados(txtPessoaJuridica);
            }

            //ao final o form é limpado
            Limpar(this);
        }   

        //função para limpar os campos
        public void Limpar(Control parent)
        {
            //percorre todos os componentes do form
            foreach (Control c in parent.Controls)
            {
                //se for um txt e for diferente dos txt que exibem os dados da pessoa fisica e juridica
                if (c is TextBox txt && txt.Name != "txtPessoaFisica" && txt.Name != "txtPessoaJuridica")
                {
                    //apaga tudo
                    txt.Clear();
                }

                //se o componente analisado tiver filhos
                else if (c.HasChildren)
                {
                    //chama a função novamente passando esse componente como parâmetro
                    Limpar(c);
                }
            }
        }
    }
}
