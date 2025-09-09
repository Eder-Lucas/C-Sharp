namespace CadastroClientes
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
            if (painelPessoaFisica.Visible)
            {
                PessoaFisica pF = new PessoaFisica
                {
                    Nome = txtNomePessoaFisica.Text,
                    Endereco = txtEnderecoPessoaFisica.Text,
                    Cpf = txtCPF.Text,
                    Rg = txtRG.Text
                };

                txtPessoaFisica.Text += $"{pF.Nome}\t {pF.Endereco}\t {pF.Cpf}\t {pF.Rg}\r\n";
            }
            else
            {
                PessoaJuridica pJ = new PessoaJuridica
                {
                    Nome = txtEnderecoPessoaJuridica.Text,
                    Endereco = txtEnderecoPessoaJuridica.Text,
                    Cnpj = txtCNPJ.Text,
                    Ie = txt_IE.Text
                };

                txtPessoaJuridica.Text += $"{pJ.Nome}\t {pJ.Endereco}\t {pJ.Cnpj}\t {pJ.Ie}\r\n";
            }

            Limpar(this);
        }

        //classe pessoa
        public class Pessoa
        {
            //atributos
            private string _nome;
            private string _endereco;

            //propriedade pública do atributo nome
            public string Nome
            {
                //método que salva e mostra os dados
                set { _nome = value; }
                get { return _nome; }
            }

            //propriedade pública do atributo endereço
            public string Endereco
            {
                set { _endereco = value; }
                get { return _endereco; }
            }
        }

        //classe pessoa física filha da classe pessoa
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
