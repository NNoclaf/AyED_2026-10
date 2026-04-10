using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_de_10_condicioanles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su presupuesto disponible: ");
            double presu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese todo lo que cuestanlos materiales: ");
            double costo = Convert.ToDouble(Console.ReadLine());

            if (costo > presu)
            {
                double faltante = costo - presu;
                Console.WriteLine("Faltan $" + faltante + " para completar y hacer la obra");
            }
            else
            {
                Console.WriteLine("El presupuesto es suficiente");
            }
        }
    }
}
