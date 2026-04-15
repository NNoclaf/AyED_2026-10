using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de facturas que se producieron: ");
            int producidas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la cantidad de docena que se vendieron: ");
            int docenas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el precio de la docena: ");
            int precio = Convert.ToInt32(Console.ReadLine());

            int vendidas = docenas * 12;
            int sobrantes = producidas - vendidas;
            int dinero = docenas * precio;

            Console.WriteLine("Las facturas que sobran son: " + sobrantes);
            Console.WriteLine("El dinero recaudado es de: $" + dinero);

            if (sobrantes > 6)
            {
                Console.WriteLine("Alerta: Exceso de producción");
            }
            else
            {
                Console.WriteLine("Producción eficiente");
            }
        }
    }
}
