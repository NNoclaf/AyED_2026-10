using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int nota = 0;
            int i = 1;

            while (i <= 5)
            {
                Console.Write("Ingrese una nota: ");
                nota = int.Parse(Console.ReadLine());

                acumulador = acumulador + nota;

                i++;
            }

            int promedio = acumulador / 5;

            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
