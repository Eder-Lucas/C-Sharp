using System;
using System.Collections.Generic;
using System.Text;

namespace Academia
{
    internal class CursorUtils
    {
        // Método para aplicar o cursor de mão em botões de ToolStrip
        public static void HandToolStripButton(ToolStrip ts)
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
                if (cbo.DropDownStyle == ComboBoxStyle.DropDownList)
                {
                    cbo.Cursor = Cursors.Hand;
                }
                else
                {
                    cbo.MouseMove += (s, e) =>
                    {
                        ComboBox? combo = s as ComboBox;

                        int larguraSeta = SystemInformation.VerticalScrollBarWidth;

                        // Se o mouse estiver na área da seta (lado direito)
                        if (e.X >= combo?.Width - larguraSeta)
                            combo?.Cursor = Cursors.Hand;
                        else
                            combo?.Cursor = Cursors.IBeam; // cursor de digitação
                    };

                    cbo.MouseLeave += (s, e) =>
                    {
                        (s as ComboBox).Cursor = Cursors.Default;
                    };
                }
            }

            foreach (var rdb in parent.Controls.OfType<RadioButton>())
            {
                rdb.MouseEnter += (s, e) => parent.Cursor = Cursors.Hand;
                rdb.MouseLeave += (s, e) => parent.Cursor = Cursors.Default;
            }

            // Verifica se o controle possui filhos, aplicando o evento mesmo em controles aninhados
            // Como: GroupBox, Panel, TabPage, etc
            foreach (Control ctl in parent.Controls)
                if (ctl.HasChildren) HandButton(ctl);
        }

        // Método público que ajusta o cursor em todos os MaskedTextBox
        public static void AjustaCursorMaskedTextBox(Control parent)
        {
            // Aplica o evento Enter em todos os MaskedTextBox do formulário
            foreach (var mtb in parent.Controls.OfType<MaskedTextBox>())
                AdicionaEvento(mtb);

            // Verifica se o controle possui filhos, aplicando o evento recursivamente
            foreach (Control ctl in parent.Controls)
                if (ctl.HasChildren) AjustaCursorMaskedTextBox(ctl);
        }

        // Método privado que adiciona o evento Enter ao MaskedTextBox
        private static void AdicionaEvento(MaskedTextBox mtb)
        {
            // Se o MaskedTextBox for nulo, sai do método
            if (mtb == null) return;

            // Remove o evento para evitar múltiplas inscrições, em seguida, adiciona o evento
            mtb.Enter -= MaskedTextBox_Enter;
            mtb.Enter += MaskedTextBox_Enter;
        }

        // Evento privado que formata o cursor ao entrar no MaskedTextBox
        // Observação: o parâmetro 'sender' pode ser null conforme o delegado EventHandler (object? sender)
        private static void MaskedTextBox_Enter(object? sender, EventArgs e)
        {
            // Se o que disparou o evento não for um MaskedTextBox, sai do método
            if (sender is not MaskedTextBox mtb) return;

            // Visto que, o Windwos processa o evento Enter e só depois roda suas rotinas internas
            // O BeginInvoke: espera o Windows terminar sua rotina antes de ajustar o cursor
            // Sem o BeginInvoke, o cursor seria colocado onde o usuário clicou

            // Executa o ajuste do cursor de forma assíncrona
            mtb.BeginInvoke((MethodInvoker)(() =>
            {
                // Verifica se o MaskedTextBox está vazio, desconsiderando os caracteres da máscara
                if (mtb.MaskedTextProvider?.AssignedEditPositionCount == 0)
                {
                    // Encontra a primeira posição editável do campo
                    int pos = mtb.MaskedTextProvider.FindEditPositionFrom(0, true);

                    // Ajusta o cursor para a primeira posição editável e garante que não selecione nenhum texto
                    mtb.SelectionStart = pos;
                    mtb.SelectionLength = 0;
                }
                // Caso contrário, ou seja, se conter caracteres seleciona todo o texto do MaskedTextBox
                else
                {
                    mtb.SelectAll();
                }
            }));
        }
    }
}
