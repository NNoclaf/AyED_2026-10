using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroSecreto = 11;
            int usuario = 0;
            int intentos = 0;

            while (usuario != numeroSecreto && intentos < 5)
            {
                Console.Write("Ingrese un numero: ");
                usuario = int.Parse(Console.ReadLine());

                intentos++;

                if (usuario < numeroSecreto)
                {
                    Console.WriteLine("El numero es mayor");
                }
                else
                {
                    if (usuario > numeroSecreto)
                    {
                        Console.WriteLine("El numero es menor");
                    }
                }
            }

            if (Usuario == numeroSecreto)
            {
                Console.WriteLine("Ganaste");

                Console.WriteLine("Intentos usados: " + intentos);
            }
            else
            {
                Console.WriteLine("Perdiste");

                Console.WriteLine("Intentos usados: " + intentos);
            }
        }
    }
}
