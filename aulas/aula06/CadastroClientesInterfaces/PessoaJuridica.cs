using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesInterfaces
{
    //classe das pessoas juridicas
    //filho de Pessoa
    internal class PessoaJuridica : Pessoa
    {
        //atributos
        public string Cnpj { get; set; }
        public string Ie { get; set; }

        //método
        public override void MostrarDados(TextBox txt)
        {
            base.MostrarDados(txt); //carrega os dados da base, ou seja, Class Pessoa

            //mostra os dados salvos
            txt.AppendText($"{Cnpj}\t {Ie}\r\n");
        }
    }
}
