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
    
    int menor;
    int mayor;
    int cantidad = 0;
}
        Console.Write("ponga el primer numero: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("ponga el segundo numero: ");
        int numero2 = int.Parse(Console.ReadLine());

        menor = numero1;
        mayor = numero2;
        if (numero2 < numero1)
        {
            menor = numero2;
            mayor = numero1;
        }

        MostrarPrimos();
    }

    static void MostrarPrimos()
    {
        Console.WriteLine("de numeros primos hay:");

        for (int numero = menor; numero <= mayor; numero++)
        {
            int divisores = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores++;
                }
            }

            if (divisores == 2)
            {
                Console.WriteLine(numero); 
                cantidad++;               
            }
        }

        Console.WriteLine("la cantidad total de primos es: " + cantidad);
    }
}
