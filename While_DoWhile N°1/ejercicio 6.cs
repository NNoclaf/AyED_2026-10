using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero limite: ");
            int limite = int.Parse(Console.ReadLine());

            int i = 1;

            while (i <= limite)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;
            }
        }
    }
}
