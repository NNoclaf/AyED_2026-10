using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número entero positivo: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Comenzando la cuenta regresiva:");

        while (numero >= 0)
        {
            Console.WriteLine(numero);

            numero--;
        }
    }
}
}
