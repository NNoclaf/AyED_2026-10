using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de midiclorianos: ");
            int midiclorianos = Convert.ToInt32(Console.ReadLine());

            if (midiclorianos > 15000)
            {
                Console.WriteLine("Potencial Maestro Jedi detectado. Avisar al Consejo");
            }
            else
            {
                if (midiclorianos > 5000)
                {
                    Console.WriteLine("Aceptable para entrenamiento Padawan");
                }
                else
                {
                    Console.WriteLine("No posee sensibilidad a la Fuerza");
                }
            }
        }
    }
}

