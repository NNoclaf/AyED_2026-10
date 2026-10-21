using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
class Program
{
    static void Main(string[] args)
    {
       Console.Write("ponga un numero entero positivo: ");
            int objetivo = int.Parse(Console.ReadLine());

            int encontro = 0;
            int i = 1;

            while (i < objetivo)
            {
                int fin = Fin(i, objetivo);

                if (fin > 0)
                {
                    Console.Write(objetivo + " = ");
                    Suma(i, fin);
                    Console.WriteLine();

                    encontro = 1;
                }

                i = i + 1;
            }

            if (encontro == 0)
            {
                Console.WriteLine("No puede representar una suma de numeros consecutivo");
            }
        }

        static int Fin(int inicio, int objetivo)
        {
            int suma = 0;
            int numero = inicio;

            while (suma < objetivo)
            {
                suma = suma + numero;
                numero = numero + 1;
            }

            if (suma == objetivo)
            {
                return numero - 1;
            }
            else
            {
                return 0;
            }
        }

        static void Suma(int inicio, int fin)
        {
            int numero = inicio;

            while (numero <= fin)
            {
                Console.Write(numero);

                if (numero < fin)
                {
                    Console.Write(" + ");
                }

                numero = numero + 1;
            }
        }
    }
}
