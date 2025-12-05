using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaFuncionario
{
    //classe filha de Funcionario
    public class Designer : Funcionario
    {
        //método construtor
        //inicializa todas as propriedades
        //o que recebe no parâmetro é atribuido a propriedade salva na classe
        public Designer(string nome, string cargo, decimal salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        //configura o método para mostrar os dados no lugar correto
        public override void MostrarDados(TextBox txt)
        {
            txt.AppendText($"{Nome}\t{Cargo}\t{Salario}\r\n");
        }
    }
}
