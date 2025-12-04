using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaFuncionario
{
    public interface IFuncionario
    {
        string Nome { get; set; }
        string Cargo { get; set; }
        decimal Salario { get; set; }

        void MostrarDados(TextBox txt);
    }
}
