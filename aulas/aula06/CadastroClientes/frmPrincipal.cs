using System.Configuration;
using System.Drawing;

namespace CadastroClientes
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
            //salva os dados da pessoa fisica
            PessoaFisica pF = new()
            {
                Nome = txtNomePessoaFisica.Text,
                Endereco = txtEnderecoPessoaFisica.Text,
                Cpf = txtCPF.Text,
                Rg = txtRG.Text
            };

            //salva os dados da pessoa juridica
            PessoaJuridica pJ = new()
            {
                Nome = txtEnderecoPessoaJuridica.Text,
                Endereco = txtEnderecoPessoaJuridica.Text,
                Cnpj = txtCNPJ.Text,
                Ie = txt_IE.Text
            };

            //se o painel de pessoa fisica tiver visivel
            if (painelPessoaFisica.Visible)
            {
                //se tiver erro de valida��o retorna a fun��o impedindo o fluxo restante do c�digo
                if (pF.ValidacaoErro(out string erro))
                {
                    MessageBox.Show(erro,
                        "Erro de valida��o",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //mostra os dados no txt caso passe na valida��o
                txtPessoaFisica.Text += $"{pF.Nome}\t {pF.Endereco}\t {pF.Cpf}\t {pF.Rg}\r\n";
            }

            //se o painel de pessoa juridica tiver visivel
            else
            {
                //faz a valida��o
                if (pJ.ValidacaoErro(out string erro))
                {
                    MessageBox.Show(erro,
                        "Erro de valida��o",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //mostra os dados no txt se passar na valida��o
                txtPessoaJuridica.Text += $"{pJ.Nome}\t {pJ.Endereco}\t {pJ.Cnpj}\t {pJ.Ie}\r\n";
            }

            //ao final limpa todos os txt
            Limpar(this);
        }

        //class abstrata - n�o pode criar objetos diretamente
        public abstract class Entidade
        {
            //m�todo que ser� herdado para outras classes
            public virtual bool ValidacaoErro(out string erro)//out permite retornar dois valores
            {
                //armazena o tipo do objeto(pessoFisica ou pessoaJuridica) e todas suas propriedades
                foreach (var prop in this.GetType().GetProperties())
                {   
                    //pega seu valor real e converte para string
                    //'?' evita erro se o valor for null
                    var valor = prop.GetValue(this)?.ToString();

                    //verifica se o valor � null("") ou espa�os vazios(" ")
                    if (string.IsNullOrWhiteSpace(valor))
                    {
                        //trata o erro
                        string nomeCampo = prop.Name;
                        erro = $"O campo {nomeCampo} est� vazio.";//retorno string
                        return true;//retorno bool
                    }
                }

                //se passar na valida��o
                erro = "";
                return false;
            }
        }

        //classe pessoa
        public class Pessoa : Entidade
        {
            //atributos
            private string _nome;
            private string _endereco;

            //propriedade p�blica do atributo nome
            public string Nome
            {
                //m�todo que salva e mostra os dados
                set { _nome = value; }
                get { return _nome; }
            }

            //propriedade p�blica do atributo endere�o
            public string Endereco
            {
                set { _endereco = value; }
                get { return _endereco; }
            }
        }

        //classe pessoa f�sica filha da classe pessoa
        public class PessoaFisica : Pessoa
        {
            //usando propriedades automaticas
            public string Cpf { set; get; }
            public string Rg { set; get; }
        }

        //classe pessoa juridica filha da classe pessoa
        public class PessoaJuridica : Pessoa
        {
            public string Cnpj { set; get; }
            public string Ie { set; get; }
        }

        //fun��o para limpar os campos
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
