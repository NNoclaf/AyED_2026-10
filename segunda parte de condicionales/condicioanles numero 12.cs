using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_de_condicioanles
{
class Program
{
static void Main(string[] args)
{
    Console.Write("Ingrese su peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese su altura: ");
    double altura = Convert.ToDouble(Console.ReadLine());

    double imc = peso / (altura * altura);

    if (imc > 25)
    {
        Console.WriteLine("Sobrepeso");
    }
    else
    {
        Console.WriteLine("Rango normal");
    }
}
}
}
