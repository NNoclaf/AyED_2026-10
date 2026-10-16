using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
class Program
{
static void Main(string[] args)
{
Console.Write("ponga la cantidad de numeros: ");
int cantidad = int.Parse(Console.ReadLine());

int[] numero = new int[cantidad];

for (int i = 0; i < cantidad; i++)
{
    Console.Write("ponga un numero: ");
    numero[i] = int.Parse(Console.ReadLine());
}

int[] veces = Calcu_frecu(numero);
int Mayor_repe = Frecu_mayor(veces);

resulta(numero, veces, Mayor_repe);
}


static int[] Calcu_frecu(int[] numero)
{
int[] veces = new int[numero.Length];

for (int i = 0; i < numero.Length; i++)
{
    int c = 0;
    for (int j = 0; j < numero.Length; j++)
    {
        if (numero[i] == numero[j])
        {
            c++;
        }
    }
    veces[i] = c;
}

return veces;
}


static int Frecu_mayor(int[] veces)
{
int mayor = 0;
for (int i = 0; i < veces.Length; i++)
{
    if (veces[i] > mayor)
    {
        mayor = veces[i];
    }
}
return mayor;
}


static void resulta(int[] numero, int[] veces, int Mayor_repe)
{
Console.WriteLine("el numero que mas se repitio " + Mayor_repe + " veces):");

for (int i = 0; i < numero.Length; i++)
{
    if (veces[i] == Mayor_repe)
    {
        Console.WriteLine(numero[i]);
    }
}
}
}
}
