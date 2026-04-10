using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la velocidad de un vehiuculo: ");
            int velo = Convert.ToInt32(Console.ReadLine());

            if (velo > 120)
            {
                Console.WriteLine("Multa en camino: Exceso de velocidad");
            }
            else
            {
                Console.WriteLine("Conducción segura");
            }
        }
    }
}
