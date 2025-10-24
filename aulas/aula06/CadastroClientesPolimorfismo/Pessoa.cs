using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesPolimorfismo
{
    internal class Pessoa : Entidade
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public override bool ValidacaoErro(out string erro)
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                erro = "O campo Nome não foi preenchido!";
                return true;
            }

            if (string.IsNullOrWhiteSpace(Endereco))
            {
                erro = "O campo Endereço não foi preenchido!";
                return true;
            }

            erro = "";
            return false;
        }

        public override void MostrarDados(TextBox txt)
        {
            txt.AppendText($"{Nome}\t {Endereco}\t");
        }
    }
}
