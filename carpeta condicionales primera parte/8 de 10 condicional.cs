using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_de_10_condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 5 == 0)
            {
                Console.WriteLine("El numero es multiplo del 5");
            }
            else
            {
                Console.WriteLine("El numero no es multiplo del 5");
            }
        }
    }
}
