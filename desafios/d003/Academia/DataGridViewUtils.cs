using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Academia
{
    internal class DataGridViewUtils
    {
        private static readonly Dictionary<DataGridView, HashSet<string>> mapaColunas = new();

        private static void Dtg_MouseCellEnter(object? sender, DataGridViewCellEventArgs e)
        {
            if (sender is not DataGridView dtg) return;

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (mapaColunas.TryGetValue(dtg, out var col))
            {
                string nomeColuna = dtg.Columns[e.ColumnIndex].Name;

                if (col.Contains(nomeColuna))
                    dtg.Cursor = Cursors.Hand;
            }
        }

        private static void Dtg_MouseCellLeave(object? sender, DataGridViewCellEventArgs e)
        {
            if (sender is not DataGridView dtg) return;

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            dtg.Cursor = Cursors.Default;
        }

        public static void HandButton(DataGridView dtg, params string[] col)
        {
            var colunas = new HashSet<string>(col);

            mapaColunas[dtg] = colunas;

            dtg.CellMouseLeave -= Dtg_MouseCellLeave;
            dtg.CellMouseEnter -= Dtg_MouseCellEnter;

            dtg.CellMouseEnter += Dtg_MouseCellEnter;
            dtg.CellMouseLeave += Dtg_MouseCellLeave;
        }

        public static void AjustaBarraVertical(params DataGridView[] dtgs)
        {
            foreach (var dtg in dtgs)
            {
                if (dtg == null) continue;
                if (dtg.Rows.Count == 0) continue;

                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dtg.Columns["NOME_PROFESSOR"]?.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            }
        }
    }
}
