using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un primer numero: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un segundo número: ");
            int B = int.Parse(Console.ReadLine());

            int result = 0;
            int i = 1;

            while (i <= B)
            {
                result = result + A;

                i++;
            }

            Console.WriteLine("El resultado final es: " + result);
        }
    }
}
