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
        
Console.Write("ponga la base: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Ingrese el exponente: ");
int e = int.Parse(Console.ReadLine());

int resultado = Potencia(b, e);

Console.WriteLine("el resultado sera: " + resultado);
}

static int Potencia(int b, int e)
{
int resultado = 1;

for (int i = 1; i <= e; i++)
{
    resultado = resultado * b;
}

return resultado;

    }
}
}
