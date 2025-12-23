using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    //classe ObjetoCalculo é filha da classe AbstractCalculo
    //herdando suas caracteristicas
    public class ObjetoCalculo : AbstractCalculo
    {
        //propriedades referentes aos cálculos, herdadas da classe AbstractCalculo
        public override decimal valorVisor { get; set; }
        public override decimal valorAnterior { get; set; }
        public override decimal valorResultado { get; set; }
        public override string operacao { get; set; }

        //método para realizar as operações, também herdado da classe pai
        public override decimal Calculo()
        {
            switch (operacao)
            {
                case " + ":
                    valorResultado = valorAnterior + valorVisor;
                    break;

                case " - ":
                    valorResultado = valorAnterior - valorVisor;
                    break;

                case " x ":
                    valorResultado = valorAnterior * valorVisor;
                    break;

                case " ÷ ":
                    valorResultado = valorAnterior / valorVisor;
                    break;

                default:
                    break;
            }

            return Math.Round(valorResultado, 2);
        }
    }
}
