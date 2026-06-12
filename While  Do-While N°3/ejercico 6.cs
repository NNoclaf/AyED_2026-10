using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int subtotal = 0;
            int descu = 0;

            Console.Write("Ingrese el precio del producto: ");
            int precio = int.Parse(Console.ReadLine());

            while (precio != 0)
            {
                subtotal = subtotal + precio;

                Console.Write("Ingrese el precio del producto: ");
                precio = int.Parse(Console.ReadLine());
            }

            if (subtotal > 15000)
            {
                descu = subtotal * 10 / 100;
            }

            int totalFinal = subtotal - descu;

            Console.WriteLine("Subtotal: $" + subtotal);
            Console.WriteLine("Descuento que se aplico: $" + descu);
            Console.WriteLine("Total fianl que se pago: $" + totalFinal);
        }
    }
}
