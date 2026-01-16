using ControleConsultorio.ConsultasDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleConsultorio
{
    // Classe para excluir dados de qualquer formulário
    internal static class ExcluirDados
    {
        // Método para excluir dados
        // Recebe como parâmetro o BindingSource, TableAdapterManager, DataSet e o Form atual
        // Essencial para funcionar corretamente
        public static void Excluir(
            BindingSource bindingSource,
            TableAdapterManager tableAdapterManager,
            ConsultasDataSet dataSet,
            Form form,
            string entidade
            )
        {
            if (bindingSource.Current == null) return;

            // Mensagem de confirmação
            var resultado = MessageBox.Show($"Deseja realmente excluir este {entidade}?",
                "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o usuário confirmar
            if (resultado == DialogResult.Yes)
            {
                // Remove o item atual do BindingSource (na memória)
                bindingSource.RemoveCurrent();

                // Valida os campos
                form.Validate();

                // Salva as mudanças na mémoria
                bindingSource.EndEdit();

                // Atualiza o banco de dados
                tableAdapterManager.UpdateAll(dataSet);

                // Mensagem de sucesso
                // Coloca a primeira letra de 'entidade' em maiúsculo
                MessageBox.Show($"{char.ToUpper(entidade[0]) + entidade.Substring(1)} excluído com sucesso!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
