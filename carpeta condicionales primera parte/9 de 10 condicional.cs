using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_de_10_condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la edad de su hermano: ");
            int ed1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la edad de su segundo hermano: ");
            int ed2 = Convert.ToInt32(Console.ReadLine());

            if (ed1 > ed2)
            {
                int diferencia = ed1 - ed2;
                Console.WriteLine("Su primer hermano es mayor por " + diferencia + " años");
            }
            else
            {
                int diferencia = ed2 - ed1;
                Console.WriteLine("El segundo hermano es mayor por " + diferencia + " años");
            }
        }
    }
}
