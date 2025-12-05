using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaFuncionario
{
    //interface que define os aspectos obrigatorios 
    public interface IFuncionario
    {
        //não implementa apenas diz como deve ser
        string Nome { get; set; }
        string Cargo { get; set; }
        decimal Salario { get; set; }

        void MostrarDados(TextBox txt);
    }
}
