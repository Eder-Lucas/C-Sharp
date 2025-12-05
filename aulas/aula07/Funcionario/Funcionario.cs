using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaFuncionario
{
    //classe funcionario que herda a interface
    public abstract class Funcionario : IFuncionario 
    {
        //implementa as propriedades
        public string Nome {  get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        //define o método responsável por mostrar os dados no txt correto
        //abstract <- obriga as classes filhas a implementar
        public abstract void MostrarDados(TextBox txt);
    }
}
