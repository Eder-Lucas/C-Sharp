using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();

            // Aciona o evento ao método AtualizarDadosDaAba toda vez que o frmClientes for criado
            // Selected: ativa sempre quando uma aba for selecionada
            tabControlClientes.Selected += (s, e) => CarregaDadosDaAba(e.TabPage);
        }

        // Evento de clique do botão salvar na barra de navegação
        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzariaDataSet);
        }

        // Evento de load do formulário
        private void frmClientes_Load(object sender, EventArgs e)
        {
            // Carrega os dados da aba selecionada
            CarregaDadosDaAba(tabControlClientes.SelectedTab);

            // Aplicando ajustes visuais utilizando as classes
            DataGridViewUtils.AjustaBarraVertical(dtgClientes, dtgPesquisaCliente);

            CursorUtils.AjustaCursorMaskedTextBox(this);
            CursorUtils.HandToolStripButton(clienteBindingNavigator);
            CursorUtils.HandButton(this);
        }

        //Carrega os dados dependendo da aba selecionada
        private void CarregaDadosDaAba(TabPage tabPage)
        {
            //Verifica a aba selecionada pelo nome
            switch (tabPage.Name)
            {
                //Na aba clientes, carrega os dados preenchendo o DataGridView
                case "tabPageClientes":
                    if (this.pizzariaDataSet.Cliente.Count == 0)
                        this.clienteTableAdapter.Fill(this.pizzariaDataSet.Cliente);
                    break;

                //Na aba pesquisa, limpa o DataGridView
                case "tabPagePesquisa":
                    dtgPesquisaCliente.DataSource = null;
                    break;
            }
        }

        // Ao clicar no botão de pesquisar por nome
        private void btnPesquisaNome_Click(object sender, EventArgs e)
        {
            // Se o campo tiver caracteres, executa a query que retorna os clientes filtrados por nome
            if (!String.IsNullOrWhiteSpace(txtPesquisaNome.Text))
                dtgPesquisaCliente.DataSource = clienteTableAdapter.RetornarNomeCliente(txtPesquisaNome.Text);         
        }

        // Ao clicar no botão de pesquisar por cpf, executa a query que retorna os clientes filtrados por cpf
        private void btnPesquisaCpf_Click(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = clienteTableAdapter.RetornarCpfCliente(txtPesquisaCpf.Text);            
        }

        // Ao clicar no botão de mostrar todos, executa a query que retorna todos os clientes
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = clienteTableAdapter.RetornarClientes();
        }

        // Executa a pesquisa por nome enquanto o usuário digita
        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            dtgPesquisaCliente.DataSource = clienteTableAdapter.RetornarNomeCliente(txtPesquisaNome.Text);
        }

        // Toda vez que o txtPesquisaCpf for alterado, formata o texto para o formato de cpf
        private void txtPesquisaCpf_TextChanged(object sender, EventArgs e)
        {
            // Espera o windows processar o evento
            txtPesquisaCpf.BeginInvoke((MethodInvoker)(() =>
            {
                // Cria uma string com apenas os números do campo txtPesquisaCpf
                // Where: filtra os caracteres, deixando apenas os dígitos
                // ToArray: converte o resultado do Where em um array de caracteres
                // new string: cria uma nova string a partir do array de caracteres
                string numeros = new string(txtPesquisaCpf.Text.Where(char.IsDigit).ToArray());

                // Chama o método que formata a string
                string formatado = FormataCpf(numeros);

                // Se o texto formatado for diferente do texto atual, atualiza o campo
                // Isso evita várias requisições de formatação enquanto o texto for o mesmo
                /* -------------------------- EXEMPLO -------------------------
                    
                   |      TEXTBOX     |     FORMATAÇÃO   |      RESULTADO     |
                   | "1"              | "1"              |  if NÃO executa    |
                   |                  |                  |                    |
                   | "11"             | "11"             |  if NÃO executa    |
                   |                  |                  |                    |
                   | "111"            | "111"            |  if NÃO executa    |
                   |                  |                  |                    |
                   | "1111"           | "111.1"          |  if EXECUTA        |

                   ------------------------------------------------------------
                 */
                if (txtPesquisaCpf.Text != formatado)
                {
                    // Atribui a formatação ao campo e ajusta o cursor para o final do texto
                    txtPesquisaCpf.Text = formatado;
                    txtPesquisaCpf.SelectionStart = formatado.Length;
                }
            }));         
        }

        // Método que formata uma string para o formato de cpf, utilizando um modelo pré-definido
        private string FormataCpf(string numeros)
        {
            // Define o modelo de formatação do cpf, onde # representa os dígitos
            string modelo = "###.###.###-##";

            // Variável para percorrer a posição dos digitos
            int n = 0;

            // StringBuilder: serve para montar ou manipular strings de forma eficiente, evitando a criação de várias instâncias
            var sb = new StringBuilder();

            // Loop que vai percorrer todo o modelo, substituindo os # pelos digitos da string numeros
            for (int i = 0; i < modelo.Length; i++)
            {
                // Se já tiver percorrido todos os digitos, sai do loop
                if (n >= numeros.Length)
                    break;

                // Se o caractere atual for # 
                if (modelo[i] == '#')
                {
                    // Substitui pelo digito correspondente e avança para o próximo dígito
                    sb.Append(numeros[n]);
                    n++;
                }
                // Caso contrário, ou seja, se for um caractere de formatação como . ou -
                else
                {   
                    // Adiciona . ou - quando já tiver números para continuar
                    sb.Append(modelo[i]);
                }
            }

            // Retorna o texto formatado em string
            return sb.ToString();
        }

        /* usando outro método
         * private string Formatando(string cpf)
        {
            if (cpf.Length <= 3)
                return cpf;

            if (cpf.Length <= 6)
                return $"{cpf.Substring(0,3)}.{cpf.Substring(3)}";

            if (cpf.Length <= 9)
                return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6)}";

            return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";
        }
        */
    }
}
