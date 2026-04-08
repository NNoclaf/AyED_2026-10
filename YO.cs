using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_aritmeticos_N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba un valor: ");
            int valor_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escriba un segundo valor: ");
            int valor_2 = Convert.ToInt32(Console.ReadLine());

            int suma = valor_1 + valor_2;
            int resta = valor_1 - valor_2;
            int multiplicacion = valor_1 * valor_2;
            double division = (double) valor_1 / valor_2;

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es: " + resta);
            Console.WriteLine("La multiplicacion es: " + multiplicacion);
            Console.WriteLine("La división es: " + division);
           





        }
    }
}
