using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaFuncionario
{
    public abstract class Funcionario : IFuncionario 
    {
        public string Nome {  get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public abstract void MostrarDados(TextBox txt);
    }
}
