using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_de_10_condicionales
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el monto de una compra: ");
        double monto = Convert.ToDouble(Console.ReadLine());

        if (monto > 5000)
        {
            double total = monto - (monto * 0.15);
            Console.WriteLine("El totl apagar es de: $" + total);
        }
        else
        {
            Console.WriteLine("El total apagar es de: $" + monto);
        }
    }
}
}
