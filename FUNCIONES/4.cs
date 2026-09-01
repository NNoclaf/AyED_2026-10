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

Console.Write("ponga un numero: ");
int n = int.Parse(Console.ReadLine());

int resultado = Factorial(n);

Console.WriteLine("el factorial ser: " + resultado);
}

static int Factorial(int n)
{
int factorial = 1;

for (int i = 1; i <= n; i++)
{
    factorial = factorial * i;
}

return factorial;

    }
}
}
