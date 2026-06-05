using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalRecaudado = 0;
            int cantidadVentas = 0;
            int ventaMayor = 0;

            string respuesta = "S";

            while (respuesta == "S")
            {
                Console.Write("Ingrese el precio de la venta: ");
                int venta = int.Parse(Console.ReadLine());

                totalRecaudado = totalRecaudado + venta;

                cantidadVentas++;

                if (venta > ventaMayor)
                {
                    ventaMayor = venta;
                }

                Console.Write("Desea continuar ingresando mas ventas? (S/N): ");
                respuesta = Console.ReadLine();
            }

            Console.WriteLine("Total que se recaudo: $" + totalRecaudado);
            Console.WriteLine("Cantidad total de ventas que se realizo: " + cantidadVentas);
            Console.WriteLine("Monto de la venta mas alta que se registro: $" + ventaMayor);
        }
    }
}
