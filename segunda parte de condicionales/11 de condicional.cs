using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_11
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese numero de lado: ");
        int lado1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese numero del segundo lado: ");
        int lado2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese numero del tercer lado: ");
        int lado3 = Convert.ToInt32(Console.ReadLine());

        if (lado1 == lado2)
        {
            if (lado2 == lado3)
            {
                Console.WriteLine("Equilatero");
            }
            else
            {
                Console.WriteLine("Isosceles");
            }
        }
        else
        {
            if (lado1 == lado3)
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                if (lado2 == lado3)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Escaleno");
                }
            }
        }
    }
}
}
