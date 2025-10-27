using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesPolimorfismo
{
    //class pai Entidade
    internal abstract class Entidade
    {
        //usando polimorfismo
        //definindo os metódos que serão adaptados dependendo da classe

        //metódo que vai validar os campos
        public virtual bool ValidacaoErro(out string erro)
        {
            erro = "";
            return false;
        }

        //metódo que mostra os valores
        public abstract void MostrarDados(TextBox txt);
    }
}
