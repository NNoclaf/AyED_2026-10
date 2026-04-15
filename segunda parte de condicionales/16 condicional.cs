using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_16
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese su promedio: ");
        double prom = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese su distancia a la facultad: ");
        int dist = Convert.ToInt32(Console.ReadLine());

        if (prom > 8)
        {
            Console.WriteLine("Beca concedida");
        }
        else
        {
            if (dist > 50)
            {
                Console.WriteLine("Beca concedida");
            }
        }
    }
}
}
