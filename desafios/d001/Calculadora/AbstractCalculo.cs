using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public abstract class AbstractCalculo
    {
        //propriedades abstratas
        public abstract decimal valorVisor { set; get; }
        public abstract decimal valorAnterior { set; get; }
        public abstract decimal valorResultado { set; get; }
        public abstract string operacao { set; get; }

        //Método abstrato do tipo decimal
        public abstract decimal Calculo();
    }
}
