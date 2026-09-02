using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
           int encontrado = 0;
int[] numeros = new int[15];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Ingrese un numero vendido: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.Write("Ingrese el numero que quiere buscar: ");
int numeroBuscado = int.Parse(Console.ReadLine());

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == numeroBuscado)
    {
        encontrado++;
    }
}

if (encontrado > 0)
{
    Console.WriteLine("El numero fue vendido");
}
else
{
    Console.WriteLine("El numero esta disponible");
}
        }
    }
}
