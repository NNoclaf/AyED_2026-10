using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_de_10_condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la temperatura: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Peligro de congelamiento");
            }
            else
            {
                if (temp <= 15)
                {
                    Console.WriteLine("Mucho frío");
                }
                else
                {
                    Console.WriteLine("Clima agradable");
                }
            }
        }
    }
}
