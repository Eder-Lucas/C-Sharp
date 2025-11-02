using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesInterfaces
{
    //classe das pessoas fisicas
    //filho de Pessoa
    internal class PessoaFisica:Pessoa 
    {
        //atributos
        public string Cpf {  get; set; }
        public string Rg {  get; set; }

        //método
        public override void MostrarDados(TextBox txt)
        {
            base.MostrarDados(txt); //carrega os dados da base, ou seja, Class Pessoa

            //mostra os dados salvos
            txt.AppendText($"{Cpf}\t {Rg}\r\n");
        }
    }
}
