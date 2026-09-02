using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
class Program
{
    static void Main(string[] args)
    {
       int total1 = 0;
int total2 = 0;

int[] sucursal1 = new int[5];
int[] sucursal2 = new int[5];

for (int i = 0; i < sucursal1.Length; i++)
{
Console.Write("ponga venta de sucursal 1: ");
sucursal1[i] = int.Parse(Console.ReadLine());

Console.Write("ponga venta de sucursal 2: ");
sucursal2[i] = int.Parse(Console.ReadLine());

total1 = total1 + sucursal1[i];
total2 = total2 + sucursal2[i];
}

for (int i = 0; i < sucursal1.Length; i++)
{
if (sucursal1[i] > sucursal2[i])
{
    Console.WriteLine("el dia " + (i + 1) + " vendio mas la sucursal 1");
}
else (sucursal2[i] > sucursal1[i])
{
    Console.WriteLine("el dia " + (i + 1) + " vendio mas la sucursal 2");
}

if (total1 > total2)
{
Console.WriteLine("sucursal 1 recaudo mas en la semana");
}
else (total2 > total1)
{
Console.WriteLine("sucursal 2 recaudo mas en la semana");
}
    }
}
}
