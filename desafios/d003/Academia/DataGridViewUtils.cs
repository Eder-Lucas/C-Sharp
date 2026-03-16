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

        public static void AjustaBarraVertical(string campo, params DataGridView[] dtgs)
        {
            foreach (var dtg in dtgs)
            {
                if (dtg == null) continue;
                if (dtg.Rows.Count == 0) continue;

                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dtg.Columns[campo]?.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            }
        }

        // OBS: usar depois de carregar os dados no DataGrid
        public static void RemoveOrdenacao(params DataGridView[] dtgs)
        {
            if (dtgs == null) return;

            // Para cada DataGridView fornecido
            foreach (var dtg in dtgs)
            {
                if (dtg == null) continue;

                // Para cada coluna desse DataGridView fornecido, desabilita a ordenação
                foreach (DataGridViewColumn coluna in dtg.Columns)
                {
                    coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        // Aplica o efeito zebrado aos dataGridView fornecidos
        public static void EstiloZebrado(params DataGridView[] dtgs)
        {
            foreach (var dtg in dtgs)
            {
                if (dtg == null) continue;

                int linhas = dtg.Rows.Count;               
                
                for (int i = 0; i < linhas; i++)
                {
                    dtg.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.White : Color.LightGray;
                }
            }            
        }
    }
}
