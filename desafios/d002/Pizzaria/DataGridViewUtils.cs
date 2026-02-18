using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    // Classe utilitária para ajustes visuais relacionados ao DataGridView
    internal static class DataGridViewUtils
    {
        // Método que ajusta a barra vertical dos DataGridView
        // params DataGridView[] dtgs: permite passar vários dtgs de uma vez
        // Ex: DataGridViewUtils.AjustaBarraVertical(dtg1, dtg2, dtg3);
        public static void AjustaBarraVertical(params DataGridView[] dtgs)
        {
            // Percorre cada DataGridView passado como parâmetro
            foreach (var dtg in dtgs)
            {
                // Se o dtg for nulo ou não tiver linhas, sai do loop
                if (dtg == null) continue;
                if (dtg.Rows.Count == 0) continue;

                // Desliga o ajuste automático para evitar redimensionamento indesejado
                // Em seguida, pega apenas a última coluna e coloca o ajuste para preencher o espaço restante
                // Compensando a largura que a barra vertical ocupa
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dtg.Columns[dtg.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            }
        }
    }
}
