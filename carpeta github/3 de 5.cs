using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la distancia al destino en años luz: ");
            int distancia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el combustible que hay en litros: ");
            int combustible = Convert.ToInt32(Console.ReadLine());

            int necesario = distancia * 12;

            if (combustible >= necesario)
            {
                Console.WriteLine("Cálculos precisos. Saltando al hiperespacio");
            }
            else
            {
                int faltante = necesario - combustible;
                Console.WriteLine("Peligro: Combustible insuficiente. Faltan " + faltante + " litros");
            }
        }
    }
}
