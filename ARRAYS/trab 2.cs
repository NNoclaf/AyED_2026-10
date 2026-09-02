using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tra2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int aprobados = 0;
            int reprobados = 0;
            int[] alumno = new int[10];
            for (int i = 0; i < alumno.Length; i++)
            {
                Console.Write("ingrese la nota del almno: ");
                alumno[i] = int.Parse(Console.ReadLine());
                suma = suma + alumno[i];
                if (alumno[i] >= 6)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }
            int promedio = suma / 10;
            Console.WriteLine("tenems " + aprobados + " de aprobados y " + reprobados + " reprobados el prodio fue de " + promedio + "");
        }
    }
}
