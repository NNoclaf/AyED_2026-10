using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch___1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor segun la lista");
            Console.WriteLine("1. Primavera");
            Console.WriteLine("2. Verano");
            Console.WriteLine("3. Otoño");
            Console.WriteLine("4. Invierno");
            Console.WriteLine("Ponga la opcion que desee: ");

            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("La opcion que se eligio fue Primavera");
                    break;
                case 2:
                    Console.WriteLine("La opcion que se eligio fue Verano");
                    break;
                case 3:
                    Console.WriteLine("La opcion que se eligio fue Otoño");
                    break;
                case 4:
                    Console.WriteLine("La opcion que se eligio fue Invierno");
                    break;
                default:
                    Console.WriteLine("La opcion que se eligio no se considera valida");
                    break;
            }
        }
    }
}
