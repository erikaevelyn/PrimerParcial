using System;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {

            Solucion sol = new Solucion();

            Console.WriteLine("Ejercicio 1");
            sol.anteceder();
            

            Console.WriteLine("Ejercicio 2");
            sol.calcularTemperatura();
            
            Console.WriteLine("Ejercicio 3");
            sol.actuar();


        }
    }
}
