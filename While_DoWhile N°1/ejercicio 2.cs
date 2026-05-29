using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_2
{
class Program
{
static void Main(string[] args)
{
    Console.Write("Ingrese una nota: ");
    int nota = int.Parse(Console.ReadLine());

    do
    {
        if (nota >= 1 && nota <= 10)
        {
            Console.WriteLine("La nota es: " + nota);
        }
        else
        {
            Console.WriteLine("Error");

            Console.Write("Ingrese nuevamente la nota: ");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 1 && nota <= 10)
            {
                Console.WriteLine("La nota es: " + nota);
            }
        }

    } while (nota < 1 && nota > 10);
}

    } 
}
