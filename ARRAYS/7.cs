using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
class Program
{
    static void Main(string[] args)
    {
        int[] tiempos = new int[6];

for (int i = 0; i < tiempos.Length; i++)
{
Console.Write("ponga el tiempo del corredor: ");
tiempos[i] = int.Parse(Console.ReadLine());
}

int menor = tiempos[0];
int mayor = tiempos[0];
int posicionmenor = 0;
int posicionmayor = 0;

for (int i = 0; i < tiempos.Length; i++)
{
if (tiempos[i] < menor)
{
    menor = tiempos[i];
    posicionmenor = i;
}

if (tiempos[i] > mayor)
{
    mayor = tiempos[i];
    posicionmayor = i;
}
}

Console.WriteLine("gana el corredor N°" + (posicionmenor + 1) + " con " + menor + " segundos");
Console.WriteLine("peor tiempo tuvo el corredor N°" + (posicionmayor + 1) + " con " + mayor + " segundos");
    }
}
}
