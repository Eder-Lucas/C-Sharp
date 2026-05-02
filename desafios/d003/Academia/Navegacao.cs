using System;
using System.Collections.Generic;
using System.Text;

namespace Academia
{
    internal static class Navegacao
    {
        public static Panel? PanelPrincipal { get; set; }

        private static UserControl? ucAtivo;

        public static void AbrirUc(UserControl uc)
        {
            // Evita recarregar a mesma tela e também verifica se o painel foi definido
            if (ucAtivo == uc || PanelPrincipal == null) return; 

            PanelPrincipal.Controls.Remove(ucAtivo);    
            uc.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(uc);

            ucAtivo = uc;
        }
    }
}
