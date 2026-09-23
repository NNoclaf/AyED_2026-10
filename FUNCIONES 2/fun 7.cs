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
   
    int numero;
    int divisor = 2;
    int cantidad = 0;

    static void Main()
    {
        Console.Write("ponga un numero entero positivo: ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine("factores primos:");
        
        Factores();

        Total();
    }

    static void Factores()
    {
        while (numero > 1)
        {
            if (numero % divisor == 0)
            {
                Console.WriteLine(divisor);
                numero = numero / divisor;  
                cantidad++;                 
            }
            else
            {
                divisor++;
            }
        }
    }

    static void Total()
    {
        Console.WriteLine("de factores primos hay: " + cantidad);
    }
}
