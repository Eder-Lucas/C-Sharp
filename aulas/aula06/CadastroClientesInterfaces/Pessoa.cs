using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesInterfaces
{
    internal abstract class Pessoa : Ipessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public virtual void MostrarDados(TextBox txt)
        {
             txt.AppendText($"{Nome}\t {Endereco}\t");
        }
    }
}
