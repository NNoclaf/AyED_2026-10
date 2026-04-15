using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar horas en las que dejo el auto: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese cuanto dinero va a pagar: ");
            int dinero = Convert.ToInt32(Console.ReadLine());

            int costo;

            if (horas == 1)
            {
                costo = 4000;
            }
            else
            {
                costo = 4000 + (horas - 1) * 1600;
            }

            if (dinero >= costo)
            {
                int vuelto = dinero - costo;
                Console.WriteLine("La paga fue echa, el vuelto es de: $" + vuelto);
            }
            else
            {
                int falta = costo - dinero;
                Console.WriteLine("Faltan $" + falta + " para que retire el auto");
            }

        }
    }
}
