using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;

            while (opc != 3)
            {
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Despedirse");
                Console.WriteLine("3. Salir");

                Console.Write("Ingrese una opcion: ");
                opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    Console.WriteLine("Hola");
                }
                else
                {
                    if (opc == 2)
                    {
                        Console.WriteLine("Adios");
                    }
                    else
                    {
                        if (opc == 3)
                        {
                            Console.WriteLine("Saliendo del programa");
                        }
                        else
                        {
                            Console.WriteLine("Opcion invalida");
                        }
                    }
                }
            }
        }
    }
}
