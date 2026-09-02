using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
           int encontrado = 0;
int[] numeros = new int[15];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("ponga un numero: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.Write("ponga el numero q busca: ");
int buscado = int.Parse(Console.ReadLine());

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == buscado)
    {
        encontrado++;
    }
}

if (encontrado > 0)
{
    Console.WriteLine("el numero fue vendido");
}
else
{
    Console.WriteLine("el numero sigue disponible");
}
        }
    }
}
