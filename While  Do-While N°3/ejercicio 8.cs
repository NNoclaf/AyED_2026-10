using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaedad = 0;
            int cantidad = 0;
            int mayores = 0;
            int menores = 0;

            Console.Write("Ingrese una edad: ");
            int edad = int.Parse(Console.ReadLine());

            while (edad >= 0)
            {
                sumaedad = sumaedad + edad;

                cantidad++;

                if (edad >= 18)
                {
                    mayores++;
                }
                else
                {
                    menores++;
                }

                Console.Write("Ingrese una edad: ");
                edad = int.Parse(Console.ReadLine());
            }

            int promedio = sumaedad / cantidad;

            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("mayores: " + mayores);
            Console.WriteLine("Menores: " + menores);

        }
    }
}
