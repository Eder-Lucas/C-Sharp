using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    internal static class DataGridViewUtils
    {
        public static void AjustaBarraVertical(params DataGridView[] dtgs)
        {
            foreach (var dtg in dtgs)
            {
                if (dtg == null) continue;
                if (dtg.Rows.Count == 0) continue;

                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dtg.Columns[dtg.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            }
        }
    }
}
