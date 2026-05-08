using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_un_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int conta = 0;
            int gasto = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingrese el gasto N° " + i + ": ");
                gasto = int.Parse(Console.ReadLine());

                acumulador = acumulador + gasto;

                if (gasto > 500)
                {
                    conta = conta + 1;
                }
            }

            Console.WriteLine("El gasto total es de: $" + acumulador);
            Console.WriteLine("La cantidad de gastos mayores a $500 son: " + conta);
        }
    }
}
