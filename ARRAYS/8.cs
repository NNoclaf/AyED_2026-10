using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int uno = 0;
int dos = 0;
int tres = 0;
int cuatro = 0;
int cinco = 0;

int[] respuestas = new int[25];

for (int i = 0; i < respuestas.Length; i++)
{
    Console.Write("calificque del 1 al 5: ");
    respuestas[i] = int.Parse(Console.ReadLine());

    if (respuestas[i] == 1)
    {
        uno++;
    }
    else if (respuestas[i] == 2)
    {
        dos++;
    }
    else if (respuestas[i] == 3)
    {
        tres++;
    }
    else if (respuestas[i] == 4)
    {
        cuatro++;
    }
    else if (respuestas[i] == 5)
    {
        cinco++;
    }
}

Console.WriteLine("cantidad de 1: " + uno);
Console.WriteLine("cantidad de 2: " + dos);
Console.WriteLine("cantidad de 3: " + tres);
Console.WriteLine("cantidad de 4: " + cuatro);
Console.WriteLine("cantidad de 5: " + cinco);
        }
    }
}
