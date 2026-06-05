using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo = 10000;
            int opci = 0;

            while (opci != 4)
            {
                Console.WriteLine("1. Depositar dinero");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Ver saldo actual");
                Console.WriteLine("4. Salir");

                Console.Write("Ingrese una de las opciones: ");
                opci = int.Parse(Console.ReadLine());

                switch (opci)
                {
                    case 1:

                        Console.Write("Ingrese el dinero que va a depositar: ");
                        int deposito = int.Parse(Console.ReadLine());

                        saldo = saldo + deposito;

                        Console.WriteLine("Saldo actual: $" + saldo);

                        break;

                    case 2:

                        Console.Write("Ingrese el dinero que va a retirar: ");
                        int retiro = int.Parse(Console.ReadLine());

                        saldo = saldo - retiro;

                        Console.WriteLine("Saldo actual: $" + saldo);

                        break;

                    case 3:

                        Console.WriteLine("Su saldo actual es: $" + saldo);

                        break;

                    case 4:

                        Console.WriteLine("Saliendo del cajero");

                        break;

                    default:

                        Console.WriteLine("Opción invalida");

                        break;
                }
            }
        }
    }
}
