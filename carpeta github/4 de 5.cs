using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de droides: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            int precio = 2000;

            
            int total = cantidad * precio;

            if (cantidad >= 3)
            {
                double descuento = total * 0.20;
                double final = total - descuento;

                Console.WriteLine("El precio total original es de: $" + total);
                Console.WriteLine("El descuento: $" + descuento);
                Console.WriteLine("El precio final es: $" + final);
            }
            else
            {
                Console.WriteLine("El total a pagar es de: $" + total);
            }
        }
    }
}
