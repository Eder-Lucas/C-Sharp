using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesPolimorfismo
{
    internal class PessoaJuridica : Pessoa
    {
        public string Cnpj { set; get; }
        public string Ie { set; get; }

        public override bool ValidacaoErro(out string erro)
        {
            if (base.ValidacaoErro(out erro)) return true;

            if (string.IsNullOrWhiteSpace(Cnpj))
            {
                erro = "O campo CNPJ deve ser preenchido!";
                return true;
            }

            if (string.IsNullOrWhiteSpace(Ie))
            {
                erro = "O campo IE deve ser preenchido!";
                return true;
            }

            erro = "";
            return false;
        }

        public override void MostrarDados(TextBox txt)
        {
            base.MostrarDados(txt);
            txt.AppendText($"{Cnpj}\t {Ie}\r\n");
        }
    }
}
