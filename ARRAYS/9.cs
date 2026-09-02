using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
int posicion = 0;

int[] precios = new int[10];

for (int i = 0; i < precios.Length; i++)
{
    Console.Write("ponga el precio del producto: ");
    precios[i] = int.Parse(Console.ReadLine());

    total = total + precios[i];
}

Console.Write("ponga posicion del producto que quiere devolver: ");
posicion = int.Parse(Console.ReadLine());

int devolucion = precios[posicion - 1];

Console.WriteLine("el precio del producto es: " + devolucion);

total = total - devolucion;

Console.WriteLine("el nuevo total es: " + total);
        }
    }
}
