using System;

namespace Cap4YCap5
{
    class Program
    {
        static void Main(string[] args)
        {

            TablaMultiplicacion t = new TablaMultiplicacion();
            t.Tablas();

            Potencia p = new Potencia();
            p.ElevePotencia();

            Promedio pro = new Promedio();
            pro.PromedioEdad();

            Factoral f = new Factoral();
            f.FactoralN();


            Console.ReadLine();
        }
    }
}
