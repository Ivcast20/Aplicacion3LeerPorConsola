using System;

namespace Aplicacion3LeerPorConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número");
            int numer2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"La suma de los numeros {numero1} y {numer2} es: {numero1 + numer2}");
        }
    }
}
