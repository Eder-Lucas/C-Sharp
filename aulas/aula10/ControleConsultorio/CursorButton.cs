using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleConsultorio
{
    // Classe para aplicar o cursor de mão em botões de ToolStrip
    internal static class CursorButton
    {
        // Método para aplicar o cursor
        public static void AplicarCursor(ToolStrip ts)
        {
            // Percorre todos os itens do ToolStrip que são do tipo ToolStripButton
            // OfType<T>() filtra apenas os itens do tipo Button, não sendo necessário verificar o tipo manualmente
            foreach (ToolStripItem item in ts.Items.OfType<ToolStripButton>())
            {
                // Adiciona os eventos para alterar o cursor
                item.MouseEnter += (s, e) => ts.Cursor = Cursors.Hand;
                item.MouseLeave += (s, e) => ts.Cursor = Cursors.Default;
            }            
        }
    }
}
