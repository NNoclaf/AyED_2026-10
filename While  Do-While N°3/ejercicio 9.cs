using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un numero positivo, y un negativo para finalizar: ");
            numero = int.Parse(Console.ReadLine());

            int menor = numero;

            while (numero >= 0)
            {
                if (numero < menor)
                {
                    menor = numero;
                }

                Console.Write("Ingrese un numero positivo, y un negativo para finalizar: ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El numero menor es: " + menor);
        }
    }
}
