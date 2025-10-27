using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadastroClientesPolimorfismo
{
    //filha da class entidade
    internal class Pessoa : Entidade
    {
        //atributos especificos
        public string Nome { get; set; }
        public string Endereco { get; set; }

        //metódo de validação por polimorfismo
        public override bool ValidacaoErro(out string erro)
        {
            //verifica se tem campos vazios
            if (string.IsNullOrWhiteSpace(Nome))
            {
                erro = "O campo Nome não foi preenchido!";
                return true;
            } else if (string.IsNullOrWhiteSpace(Endereco))
            {
                erro = "O campo Endereço não foi preenchido!";
                return true;
            }

            //testando regex para validação
            string regexNome = @"^[\p{L} ]+$";
            string regexEndereco = @"^[\p{L}0-9 ]+, [\p{L}0-9 \-]+$";

            //valida o dado enviado com regex
            if (!Regex.IsMatch(Nome, regexNome))
            {
                erro = $"O campo Nome não foi preenchido corretamente.";
                return true;
            }

            if (!Regex.IsMatch(Endereco, regexEndereco))
            {
                erro = $"O campo Endereço não foi preenchido corretamente.";
                return true;
            }

            //caso não possua erros
            erro = "";
            return false;
        }

        //mostra os dados por polimorfismo
        public override void MostrarDados(TextBox txt)
        {
            txt.AppendText($"{Nome}\t {Endereco}\t");
        }
    }
}
