namespace SistemaFuncionario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome inválido. Por favor, digite um nome.", "ERRO DE VALIDAÇÃO",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                txtNome.Focus();
                return;
            }

            if (cboCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Cargo inválido. Por favor, selecione um cargo válido","ERRO DE VALIDAÇÃO",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            if (!decimal.TryParse(txtSalario.Text, out decimal salario) || salario <= 0)
            {
                MessageBox.Show("Digite um valor válido para o salário", "ERRO DE VALIDAÇÂO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return;
            }

            Funcionario funcionario;

            switch (cboCargo.Text)
            {
                case "Assistente Administrativo":
                    funcionario = new Administrativo(txtNome.Text, cboCargo.Text, salario);
                    break;

                case "Assistente de Designer":
                    funcionario = new Designer(txtNome.Text, cboCargo.Text, salario);
                    break;

                default:
                    MessageBox.Show(
                        "Selecione um cargo válido",
                        "ERRO DE ENTRADA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
            }

            funcionario.MostrarDados(txtFuncionario);

            Limpar();
            txtNome.Focus();
        }
        public void Limpar()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt && txt.Name != "txtFuncionario")
                {
                    txt.Clear();
                }
                if (c is ComboBox cbo)
                {
                    cbo.SelectedIndex = -1;
                }
            }
        }
    }
}
