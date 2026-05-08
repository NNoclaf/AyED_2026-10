using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_un_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eliga un idioma:");
            Console.WriteLine("1. Inglés");
            Console.WriteLine("2. Francés");
            Console.WriteLine("3. Alemán");

            Console.Write("Ingrese una opcion: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Salut");
                    break;
                case 3:
                    Console.WriteLine("Hallo");
                    break;
                default:
                    Console.WriteLine("La opcion no es valida");
                    break;
            }
        }
    }
}
