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
            int numero = int.Parse(Console.ReadLine());

            int encontro = 0;

            for (int i = 1; i < numero; i++)
            {
                int Valida = Verifica_suma(i, numero);

                if (Valida == 1)
                {

                    Console.Write(numero + " = ");
                    Mostrar(i, numero);
                    Console.WriteLine();
                    encontro = 1;
                }
            }

            if (encontro == 0)
            {
                Console.WriteLine("no se representa suma de numeros consecutivo");
            }
        }

        static int Verifica_suma(int inicio, int objetivo)
        {
            int suma = 0;

            for (int j = inicio; suma < objetivo; j++)
            {
                suma = suma + j;
            }

            if (suma == objetivo)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static void Mostrar(int inicio, int objetivo)
        {
            int suma = 0;

            for (int j = inicio; suma < objetivo; j++)
            {
                suma = suma + j;
                Console.Write(j);

                if (suma < objetivo)
                {
                    Console.Write(" + ");
                }
            }
        }
    }
}

