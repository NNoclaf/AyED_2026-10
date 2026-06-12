using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int presentes = 0;
            int ausentes = 0;

            string respu = "S";

            while (respu == "S")
            {
                Console.Write("Ingrese el nombre de un alumno: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese P para presente o A para ausente: ");
                string estado = Console.ReadLine();

                if (estado == "P")
                {
                    presentes++;
                }
                else
                {
                    if (estado == "A")
                    {
                        ausentes++;
                    }
                }

                Console.Write("Desea cargar otro alumno? (S/N): ");
                respu = Console.ReadLine();
            }

            int totalAlumno = presentes + ausentes;

            int porciento = presentes * 100 / totalAlumno;

            Console.WriteLine("La cantidad de los presentes es: " + presentes);
            Console.WriteLine("La cantidad de los ausentes son: " + ausentes);
            Console.WriteLine("El porciento de presentismo es: " + porciento+ "%");
        }
    }
}
