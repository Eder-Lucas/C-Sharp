using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesPolimorfismo
{
    internal abstract class Entidade
    {
        public virtual bool ValidacaoErro(out string erro)
        {
            erro = "";
            return false;
        }

        public abstract void MostrarDados(TextBox txt);
    }
}
