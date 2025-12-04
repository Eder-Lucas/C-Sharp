using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaFuncionario
{
    public class Designer : Funcionario
    {
        public Designer(string nome, string cargo, decimal salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public override void MostrarDados(TextBox txt)
        {
            txt.AppendText($"{Nome}\t{Cargo}\t{Salario}\r\n");
        }
    }
}
