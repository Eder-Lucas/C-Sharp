namespace SistemaFuncionario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //ao clicar no botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //---- VALIDAÇÕES ----

            //valida o campo nome
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome inválido. Por favor, digite um nome.", "ERRO DE VALIDAÇÃO",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                txtNome.Focus();
                return; //interrompe o fluxo do código
            }

            //valida o comboBox
            if (cboCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Cargo inválido. Por favor, selecione um cargo válido","ERRO DE VALIDAÇÃO",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            //valida o campo salário
            if (!decimal.TryParse(txtSalario.Text, out decimal salario) || salario <= 0)
            {
                MessageBox.Show("Digite um valor válido para o salário", "ERRO DE VALIDAÇÂO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return;
            }

            //---- LÓGICA PRINCIPAL ----

            //variável do tipo Funcionario que é abstrata e não pode ser instanciada diretamente
            //armazena tudo que foi configurado na classe funcionario e suas filhas
            Funcionario funcionario;

            //analisa qual comboBox foi selecionado para chamar a classe correspondente
            //assim o switch apenas escolhe qual classe criar por polimorfismo
            switch (cboCargo.Text)
            {
                //caso seja administrativo
                //cria o objeto do tipo desejado
                //passando os dados que devem ser salvos para o construtor
                case "Assistente Administrativo":
                    funcionario = new Administrativo(txtNome.Text, cboCargo.Text, salario);
                    break;

                case "Assistente de Designer":
                    funcionario = new Designer(txtNome.Text, cboCargo.Text, salario);
                    break;

                //caso nenhuma opção for escolhida
                //por segurança, é disparado um alerta
                default:
                    MessageBox.Show(
                        "Selecione um cargo válido",
                        "ERRO DE ENTRADA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return; //retorna evitando erro ao mostrar os dados no txt
            }

            //se tudo fluir bem os dados são mostrados no txt
            funcionario.MostrarDados(txtFuncionario);

            //ao final, limpa os campo e aplica um foco no campo nome novamente
            Limpar();
            txtNome.Focus();
        }

        //função para limpar os componentes
        public void Limpar()
        {
            //percorre cada componente usando a variavel "c"
            foreach (Control c in this.Controls)
            {
                //se for um txt exceto o txtFuncionario
                //tudo é limpado
                if (c is TextBox txt && txt.Name != "txtFuncionario")
                {
                    txt.Clear();
                }

                //limpa o comboBox
                if (c is ComboBox cbo)
                {
                    cbo.SelectedIndex = -1;
                }
            }
        }
    }
}
