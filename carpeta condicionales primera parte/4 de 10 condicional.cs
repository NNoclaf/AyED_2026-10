using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_de_10_condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la nota de un examen: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else
            {
                if (nota >= 4)
                {
                    Console.WriteLine("A finales");
                }
                else
                {
                    Console.WriteLine("Recuperatorio");
                }
            }
        }
    }
}
