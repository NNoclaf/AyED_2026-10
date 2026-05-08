using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_el_10
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un numero positivo y entero: ");
        int num = int.Parse(Console.ReadLine());

        int conta = 0;
        int divi = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                conta = conta + 1;

                if (i > 1 && i < num && divi == 0)
                {
                    divi = i;
                }
            }
        }

        if (conta == 2)
        {
            Console.WriteLine("El numero es primo");
        }
        else
        {
            Console.WriteLine("El numero no es primo");
            Console.WriteLine("El primer divisor que se econtro fue: " + divi);
        }
    }
}
}
