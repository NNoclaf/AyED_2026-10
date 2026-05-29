using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una temperatura inicial: ");
            int temperatura = int.Parse(Console.ReadLine());

            while (temperatura > 24)
            {
                temperatura = temperatura - 2;

                Console.WriteLine("Enfriando... Temperatura actual: " + temperatura + "°C");
            }

            Console.WriteLine("Temperatura ideal alcanzada");
        }
    }
}
