using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesInterfaces
{
    internal interface Ipessoa
    {
        string Nome { get; set; }
        string Endereco { get; set; }

        void MostrarDados(TextBox txt);
    }
}
