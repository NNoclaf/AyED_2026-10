using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int inasistencias = 0;
            string[] asistencia = new string[20];

            for (int i = 0; i < asistencia.Length; i++)
            {
                Console.Write("ponga P si vino, o ponga A si falto: ");
                asistencia[i] = Console.ReadLine();

                if (asistencia [i] == "A")
                {
                    inasistencias++;
                }
            }

            if (inasistencias > 6)
            {
                Console.WriteLine("Libre por inasistencias: ");
                }
            else
            {
                Console.WriteLine("Regular");
            }
            Console.WriteLine("falto: " + inasistencias);
        }
    }
}
