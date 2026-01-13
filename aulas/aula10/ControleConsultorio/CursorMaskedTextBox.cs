using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleConsultorio
{
    internal static class CursorMaskedTextBox
    {
        public static void AdicionaEvento(MaskedTextBox mtb)
        {
            if (mtb == null) return;

            mtb.Enter -= MaskedTextBox_Enter;
            mtb.Enter += MaskedTextBox_Enter;
        }

        public static void MaskedTextBox_Enter(object sender, EventArgs e)
        {
            if (!(sender is MaskedTextBox mtb)) return;

            mtb.BeginInvoke((MethodInvoker)(() =>
            {
                if (mtb.MaskedTextProvider.AssignedEditPositionCount == 0)
                {
                    int pos = mtb.MaskedTextProvider.FindEditPositionFrom(0, true);

                    mtb.SelectionStart = pos;
                    mtb.SelectionLength = 0;
                }
                else
                {
                    mtb.SelectAll();
                }
            }));
        }

        public static void AjustaCursor(Control parent)
        {
            foreach (Control ctl in parent.Controls)
            {
                if (ctl is MaskedTextBox mtb)
                {
                    AdicionaEvento(mtb);
                }

                if (ctl.HasChildren)
                {
                    AjustaCursor(ctl);
                }
            }
        }
     }
}
