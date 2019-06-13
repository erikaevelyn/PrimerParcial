using System;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {

            Solucion sol = new Solucion();

            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"La suma de los números que anteceden al {numero} es: {sol.anteceder(numero)}");

            Console.WriteLine("Ejercicio 2");
            sol.calcularTemperatura();
            
            Console.WriteLine("Ejercicio 3");
            sol.actuar();


        }
    }
}
