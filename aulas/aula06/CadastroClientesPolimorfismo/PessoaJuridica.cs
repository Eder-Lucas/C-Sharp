using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesPolimorfismo
{
    //filha da class pessoa
    internal class PessoaJuridica : Pessoa
    {
        //atributos
        public string Cnpj { set; get; }
        public string Ie { set; get; }

        //validação dos campos
        public override bool ValidacaoErro(out string erro)
        {
            //chama a validação da base: Pessoa.validacaoErro
            if (base.ValidacaoErro(out erro)) return true;

            //validação dessa class
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

        //metódo para mostrar os dados no txt
        public override void MostrarDados(TextBox txt)
        {
            //carrega dos dados da class pai Pessoa
            base.MostrarDados(txt);

            //carrega os dados de pessoa juridica
            txt.AppendText($"{Cnpj}\t {Ie}\r\n");
        }
    }
}
