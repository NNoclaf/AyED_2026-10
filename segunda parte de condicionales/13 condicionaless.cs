using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su genero: ");
            string gen = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (gen == "F")
            {
                if (edad >= 60)
                {
                    Console.WriteLine("Puede iniciar el trámite jubilatorio");
                }
            }
            else
            {
                if (gen == "M")
                {
                    if (edad >= 65)
                    {
                        Console.WriteLine("Puede iniciar el trámite jubilatorio");
                    }
                }
            }
        }
    }
}
