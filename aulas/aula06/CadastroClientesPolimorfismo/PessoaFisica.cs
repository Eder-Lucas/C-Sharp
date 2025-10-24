using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesPolimorfismo
{
    internal class PessoaFisica : Pessoa
    {
        public string Cpf { set; get; }
        public string Rg { set; get; }

        public override bool ValidacaoErro(out string erro)
        {
            if (base.ValidacaoErro(out erro)) return true;

            if (string.IsNullOrWhiteSpace(Cpf))
            {
                erro = "O campo CPF não foi preenchido!";
                return true;
            }

            if (string.IsNullOrWhiteSpace(Rg))
            {
                erro = "O campo RG não foi preenchido!";
                return true;
            }

            erro = "";
            return false;
        }

        public override void MostrarDados(TextBox txt)
        {
            base.MostrarDados(txt);
            txt.AppendText($"{Cpf}\t {Rg}\r\n");
        }

    }
}
