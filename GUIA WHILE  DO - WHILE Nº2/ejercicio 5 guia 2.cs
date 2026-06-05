using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            Console.Write("Ingrese un numero o X/n para salir: ");
            string dato = Console.ReadLine();

            while (dato != "X" && dato != "n")
            {
                int numero = int.Parse(dato);

                if (numero > 0)
                {
                    positivos++;
                }
                else
                {
                    if (numero < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        ceros++;
                    }
                }

                Console.Write("Ingrese un número o X/n para salir: ");
                dato = Console.ReadLine();
            }

            Console.WriteLine("Cantidad de positivos: " + positivos);
            Console.WriteLine("Cantidad de negativos: " + negativos);
            Console.WriteLine("Cantidad de ceros: " + ceros);
        }
    }
}
