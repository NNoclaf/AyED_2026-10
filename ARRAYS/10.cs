using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int menores = 0;
            int mayores = 0;
            int intermedios = 0;

int[] edades = new int[12];

for (int i = 0; i < edades.Length; i++)
{
    Console.Write("ponga edad del vecino: ");
    edades[i] = int.Parse(Console.ReadLine());

    if (edades[i] < 18)
    {
        menores++;
    }
    else if (edades[i] >= 65)
    {
        mayores++;
    }
    else
    {
        intermedios++;
    }
}

Console.WriteLine("de menores hay: " + menores);
Console.WriteLine("de adultos mayores hay: " + mayores);
Console.WriteLine("del rango intermedio hay: " + intermedios);
        }
    }
}
