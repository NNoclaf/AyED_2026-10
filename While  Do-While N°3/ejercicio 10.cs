using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int creditos = 100;

            do
            {
                Console.WriteLine("Creditos disponibles: " + creditos);

                Console.Write("Ingrese su apuesta, y pulse 0 para retirarse): ");
                int apuesta = int.Parse(Console.ReadLine());

                if (apuesta == 0)
                {
                    break;
                }

                if (apuesta > 0 && apuesta <= creditos)
                {
                    Console.Write("Ingrese el resultado del dado 1: ");
                    int dado1 = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el resultado del dado 2: ");
                    int dado2 = int.Parse(Console.ReadLine());

                    int suma = dado1 + dado2;

                    if (suma == 7 || suma == 11)
                    {
                        creditos = creditos + apuesta;
                        Console.WriteLine("Ganaste");
                    }
                    else
                    {
                        creditos = creditos - apuesta;
                        Console.WriteLine("Perdiste");
                    }
                }
                else
                {
                    Console.WriteLine("Apuesta invalida");
                }

            } while (creditos > 0);

            Console.WriteLine("Saldo final: " + creditos);
        }
    }
}
