using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_17
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el saldo actual: ");
        int saldo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el monto que desea retirar: ");
        int retiro = Convert.ToInt32(Console.ReadLine());

        if (retiro > saldo)
        {
            Console.WriteLine("Fondos insuficientes");
        }
        else
        {
            if (retiro % 1000 == 0)
            {
                Console.WriteLine("Retiro realizado con exito");
            }
            else
            {
                Console.WriteLine("Solo billetes de 1000");
            }
        }
    }
}
}
