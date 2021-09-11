using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap4YCap5
{
    public class TablaMultiplicacion
    {
      
        public void Tablas()
        {
            int numero = 0;

            Console.WriteLine("Ingrese la tabla del numero que desea presentar: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (i * numero));
            }

            
            Console.ReadKey(true);
        }

    }
}
