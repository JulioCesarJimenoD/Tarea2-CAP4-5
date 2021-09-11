using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap4YCap5
{
    class Promedio
    {
        public void PromedioEdad()
        {
            int persona, edad;
            int promedio = 0;

            Console.WriteLine("Ingrese la cantidad de personas: ");
            persona = int.Parse(Console.ReadLine());

            for (int i = 1; i < persona; i++)
            {
                Console.WriteLine("Ingrese la edades {0}: ",i);
                promedio += int.Parse(Console.ReadLine());
            }

            promedio = promedio / persona;
            Console.WriteLine("La edad Promedio es {0}: ", promedio);
        }
    }
}
