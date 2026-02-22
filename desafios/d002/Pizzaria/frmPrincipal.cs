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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            dtgPedido.AutoGenerateColumns = false;
        }

        // Eventos de clique dos botões para abrir os formulários correspondentes
        private void btnClientes_Click(object sender, EventArgs e) => new frmClientes().ShowDialog();
        private void btnPizzas_Click(object sender, EventArgs e) => new frmPizzas().ShowDialog();
        
        private void btnpedidos_Click(object sender, EventArgs e)
        {
            new frmPedido().ShowDialog();

            btnPesquisar.PerformClick();
        }

        // Quando o formulário principal for carregado
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Carregar os pedidos no DataGridView e verifica a situação de cada um
            dtgPedido.DataSource = pedidoTableAdapter1.RetornarPedidos();
            VerificaPedido();

            // Aplicando ajustes visuais utilizando as classes
            DataGridViewUtils.AjustaBarraVertical(dtgPedido);
            CursorUtils.HandToolStripButton(toolStrip1);
            CursorUtils.HandButton(this);
        }

        // Ao clicar no botão de Atualizar, recarrega os pedidos e verifica a situação de cada um
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dtgPedido.DataSource = pedidoTableAdapter1.RetornarPedidos();
            VerificaPedido();
        }

        // Ao clicar no botão de pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Verifica qual filtro está selecionado e realiza a consulta correspondente
            if (chkEntregue.Checked)
            {
                dtgPedido.DataSource = pedidoTableAdapter1.RetornarEntregue();
            }
            else if (chkEspera.Checked)
            {
                dtgPedido.DataSource = pedidoTableAdapter1.RetornarEspera();
            }
            else if (!String.IsNullOrEmpty(txtNomeCliente.Text))
            {
                dtgPedido.DataSource = pedidoTableAdapter1.RetornarCliente(txtNomeCliente.Text);
            }

            // No fim, verifica a situação de cada pedido
            VerificaPedido();
        }

        // Realiza a query enquanto o usuário digita no campo de pesquisa
        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            dtgPedido.DataSource = pedidoTableAdapter1.RetornarCliente(txtNomeCliente.Text);
            VerificaPedido();
        }

        // Eventos de clique dos checkbox para atualizar o filtro
        private void chkEntregue_CheckedChanged(object sender, EventArgs e) => AtualizaFiltro();
        private void chkEspera_CheckedChanged(object sender, EventArgs e) => AtualizaFiltro();

        // Método que atualiza o filtro dos pedidos dinamicamente
        private void AtualizaFiltro()
        {
            // Habilita ou desabilita os checkbox e o campo de pesquisa
            chkEspera.Enabled = !chkEntregue.Checked; // Se marcar entregue, desmarca e desabilita o checkbox de espera
            chkEntregue.Enabled = !chkEspera.Checked; // Se marcar espera, desmarca e desabilita o checkbox de entregue
            txtNomeCliente.Enabled = !chkEntregue.Checked && !chkEspera.Checked; // Só habilita se nenhum tiver marcado

            // Aplica a consulta correspondente ao filtro selecionado
            // Se nenhum filtro estiver selecionado, retorna todos os pedidos
            if (chkEntregue.Checked)
                dtgPedido.DataSource = pedidoTableAdapter1.RetornarEntregue();
            else if (chkEspera.Checked)
                dtgPedido.DataSource = pedidoTableAdapter1.RetornarEspera();
            else
                dtgPedido.DataSource = pedidoTableAdapter1.RetornarPedidos();

            // Ao final verifica a situação de cada pedido
            VerificaPedido();
        }

        // Método que verifica a situação de cada pedido e ajusta a célula de situação
        private void VerificaPedido()
        {
            // Armazena a quantidade de linhas do DataGridView Pedido
            int linha = dtgPedido.Rows.Count;

            // Se houver linhas
            if (linha > 0)
            {
                // Percorre cada uma, enquanto i for menor que a quantidade de linhas
                for (int i = 0; i < linha; i++)
                {   
                    // Se o valor da célula 'ENTREGUE' for verdadeiro, o pedido foi entregue
                    if (Convert.ToBoolean(dtgPedido.Rows[i].Cells["ENTREGUE"].Value))
                    {
                        dtgPedido.Rows[i].Cells["SITUACAO"].Value = "Entregue";
                        dtgPedido.Rows[i].Cells["SITUACAO"].Style.BackColor = Color.ForestGreen;
                        dtgPedido.Rows[i].Cells["SITUACAO"].Style.ForeColor = Color.White;
                    }
                    // Caso contrário, o pedido está em à espera
                    else
                    {
                        dtgPedido.Rows[i].Cells["SITUACAO"].Value = "À Espera";
                        dtgPedido.Rows[i].Cells["SITUACAO"].Style.BackColor = Color.DarkRed;
                        dtgPedido.Rows[i].Cells["SITUACAO"].Style.ForeColor = Color.White;
                    }
                } 
            }
        }
    }
}
