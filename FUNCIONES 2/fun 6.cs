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
        int cantidad;
        int numero;
        int mayor = 0;
        int segumayor = 0;
        bool primero = true;
        bool segundo = false;

        Console.Write("ponga la cantidad de numeros: ");
        cantidad = int.Parse(Console.ReadLine());

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("ponga un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (primero)
            {
                mayor = numero;
                primero = false;
            }
            else
            {
                if (numero > mayor)
                {
                    segumayor = mayor;
                    mayor = numero;
                    segundo = true;
                }
                else if (numero < mayor)
                {
                    if (segundo == false || numero > segumayor)
                    {
                        segumayor = numero;
                        segundo = true;
                    }
                }
            }
        }

        if (segundo)
        {
            Console.WriteLine("el segundo mas grande es: " + segumayor);
        }
        else
        {
            Console.WriteLine("no hay un segundo valor diferente al mayor");
        }
    }
}
