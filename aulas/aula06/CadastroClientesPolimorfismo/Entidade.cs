using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesPolimorfismo
{
    //class pai Entidade
    //internal: não pode ser acessada em outros projetos
    internal abstract class Entidade
    {
        //usando polimorfismo
        //definindo os metódos que serão adaptados dependendo da classe

        //método que vai validar os campos
        //virtual: significa que a classe filha pode sobrescrever, mas não é obrigada
        public virtual bool ValidacaoErro(out string erro)
        {
            erro = "";
            return false;
        }

        //método que mostra os valores
        //abstract: significa que toda classe filha é obrigada a implementar sua própria versão
        public abstract void MostrarDados(TextBox txt);
    }
}
