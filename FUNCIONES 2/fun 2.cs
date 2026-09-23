using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
class Program
{
    static void Main(string[] args)
    {
       int numero;

        Console.Write("ponga un numero entero y qsea positivo: ");
        numero = int.Parse(Console.ReadLine());

        if (Perfecto(numero))
        {
            Console.WriteLine("el numero es perfecto.");
        }
        else
        {
            Console.WriteLine("el numero no es perfecto.");
        }
    }

    static bool Perfecto(int numero)
    {
        int suma = 0;

        for (int i = 1; i < numero; i++)
        {
            if (numero % i == 0)
            {
                suma = suma + i;
            }
        }

        return suma == numero;
    }
}
