using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap4YCap5
{
   public class Factoral
    {
        public void FactoralN()
        {
            int numero;
            long resultado = 1;

            Console.WriteLine("Ingrese unn numero: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                resultado = resultado * 1;

            }
            Console.WriteLine("El factorial de {0} es {1}", numero, resultado);
        }

    }
}
