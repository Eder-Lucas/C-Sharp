using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    internal static class CursorButton
    {
        // Método para aplicar o cursor de mão em botões de ToolStrip
        public static void HandToolStrip(ToolStrip ts)
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

        // Método para aplicar o cursor de mão em botões, checkboxes e comboboxes
        public static void HandButton(Control parent)
        {
            foreach (var btn in parent.Controls.OfType<Button>())
            {
                btn.MouseEnter += (s, e) => parent.Cursor = Cursors.Hand;
                btn.MouseLeave += (s, e) => parent.Cursor = Cursors.Default;
            }

            foreach (var chk in parent.Controls.OfType<CheckBox>())
            {
                chk.MouseEnter += (s, e) => parent.Cursor = Cursors.Hand;
                chk.MouseLeave += (s, e) => parent.Cursor = Cursors.Default;
            }

            foreach (var cbo in parent.Controls.OfType<ComboBox>())
            {
                cbo.MouseEnter += (s, e) => parent.Cursor = Cursors.Hand;
                cbo.MouseLeave += (s, e) => parent.Cursor = Cursors.Default;
            }

            // Verifica se o controle possui filhos, aplicando o evento mesmo em controles aninhados
            // Como: GroupBox, Panel, TabPage, etc.
            foreach (Control ctl in parent.Controls)
                if (ctl.HasChildren) HandButton(ctl);
        }
    }
}
