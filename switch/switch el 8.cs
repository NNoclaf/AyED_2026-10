using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int conta = 0;
            int temp = 0;

            for (int i = 1; i <= 7; i++)
            {
                Console.Write("Ingrese la temperatura del día " + i + ": ");
                temp = int.Parse(Console.ReadLine());

                acumulador = acumulador + temp;

                if (temp < 0)
                {
                    conta = conta + 1;
                }
            }

            Console.WriteLine("La suma de todas las temperaturas es de: " + acumulador);
            Console.WriteLine("La cantidad de temperaturas menores a 0°C es de: " + conta);
        }
    }
}
