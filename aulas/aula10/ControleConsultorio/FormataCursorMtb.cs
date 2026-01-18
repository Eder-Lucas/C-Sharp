using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleConsultorio
{
    // Classe que coloca o cursor no início do campo MaskedTextBox
    internal static class FormataCursorMtb
    {
        // Evento que formata o cursor ao entrar no MaskedTextBox
        public static void MaskedTextBox_Enter(object sender, EventArgs e)
        {
            // Se o que disparou o evento não for um MaskedTextBox, sai do método
            if (!(sender is MaskedTextBox mtb)) return;

            // Visto que, o Windwos processa o evento Enter e só depois roda suas rotinas internas
            // O BeginInvoke: espera o Windows terminar sua rotina antes de ajustar o cursor
            // Sem o BeginInvoke, o cursor seria colocado onde o usuário clicou

            // Executa o ajuste do cursor de forma assíncrona
            mtb.BeginInvoke((MethodInvoker)(() =>
            {
                // Verifica se o MaskedTextBox está vazio, desconsiderando os caracteres da máscara
                if (mtb.MaskedTextProvider.AssignedEditPositionCount == 0)
                {
                    // Encontra a primeira posição editável do campo
                    int pos = mtb.MaskedTextProvider.FindEditPositionFrom(0, true);

                    // Ajusta o cursor para a primeira posição editável e garante que não selecione nenhum texto
                    mtb.SelectionStart = pos;
                    mtb.SelectionLength = 0;
                }
                // Caso contrário, seleciona todo o texto do MaskedTextBox
                else
                {
                    mtb.SelectAll();
                }
            }));
        }

        // Método que adiciona o evento Enter ao MaskedTextBox
        public static void AdicionaEvento(MaskedTextBox mtb)
        {
            // Se o MaskedTextBox for nulo, sai do método
            if (mtb == null) return;

            // Remove o evento para evitar múltiplas inscrições, em seguida, adiciona o evento
            mtb.Enter -= MaskedTextBox_Enter;
            mtb.Enter += MaskedTextBox_Enter;
        }

        // Método que ajusta o cursor em todos os MaskedTextBox
        public static void AjustaCursor(Control parent)
        {
            // Aplica o evento Enter em todos os MaskedTextBox do formulário
            foreach (var mtb in parent.Controls.OfType<MaskedTextBox>())
                AdicionaEvento(mtb);

            // Verifica se o controle possui filhos, aplicando o evento recursivamente
            foreach (Control ctl in parent.Controls)
                if (ctl.HasChildren) AjustaCursor(ctl);                       
        }
     }
}
