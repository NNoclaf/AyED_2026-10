using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.Write("Ingrese una opcion entre el 1 y el 3: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("El camino del Jedi sigue");
            }
            else
            {
                if (opcion == 2)
                {
                    Console.WriteLine("Un cazarrecompensas eres");
                }
                else
                {
                    if (opcion == 3)
                    {
                        Console.WriteLine("El Lado Oscuro se apodera de ti");
                    }
                    else
                    {
                        Console.WriteLine("Error en la Fuerza: opción inválida");
                    }
                }
            }
        }
    }
}
