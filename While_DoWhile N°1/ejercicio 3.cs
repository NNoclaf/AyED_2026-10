using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_3
{
class Program
{
static void Main(string[] args)
{
    Console.Write("Ingrese un numero: ");
    int num = int.Parse(Console.ReadLine());

    int acumulador = 0;

    while (num > 0 || num < 0)
    {
        acumulador = acumulador + num;

        Console.Write("Ingrese otro numero: ");
        num = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("El total que se acumulo fue de: " + acumulador);
}
}
}

