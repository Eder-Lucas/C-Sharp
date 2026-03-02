using System;
using System.Collections.Generic;
using System.Text;

namespace Academia
{
    internal class Formatador
    {
        public static string Cpf(string txt)
        {
            string numeros = new string(txt.Where(char.IsDigit).ToArray());

            string modelo = "###.###.###-##";

            int n = 0;

            var sb = new StringBuilder();

            for (int i = 0; i < modelo.Length; i++)
            {
                if (n >= numeros.Length) break;

                if (modelo[i] == '#')
                {
                    sb.Append(numeros[n]);
                    n++;
                }
                else
                {
                    sb.Append(modelo[i]);
                }
            }

            return sb.ToString();
        }


    }
}
