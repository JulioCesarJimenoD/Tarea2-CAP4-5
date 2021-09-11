using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap4YCap5
{
    class Potencia
    {
        public void ElevePotencia()
        {
            double Resultado, numero, elevador;

            Console.WriteLine("Ingrese el numero a elevar: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la potencia: ");
            elevador = int.Parse(Console.ReadLine());

            Resultado = Math.Pow(numero, elevador);
            Console.WriteLine(Resultado);
            
        }
    }
}
