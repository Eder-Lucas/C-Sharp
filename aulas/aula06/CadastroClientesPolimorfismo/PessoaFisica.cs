using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesPolimorfismo
{
    //filha da class pessoa
    internal class PessoaFisica : Pessoa
    {
        //atributos
        public string Cpf { set; get; }
        public string Rg { set; get; }

        //regra de validação única para os seus atributos
        public override bool ValidacaoErro(out string erro)
        {
            //chama a validação da base: Pessoa.ValidacaoErro
            if (base.ValidacaoErro(out erro)) return true;

            //validação dessa class
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

        //mostra seus dados
        public override void MostrarDados(TextBox txt)
        {
            //chama Pessoa.MostrarDados
            //carregando os dados anteriores
            base.MostrarDados(txt);

            //mostra os dados dessa class
            txt.AppendText($"{Cpf}\t {Rg}\r\n");
        }

    }
}
