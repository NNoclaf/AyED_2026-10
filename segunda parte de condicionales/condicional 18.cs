using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un tercer numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El que es mayor es: " + num1);
                }
                else
                {
                    Console.WriteLine("El que es mayor es: " + num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El que es mayor es: " + num2);
                }
                else
                {
                    Console.WriteLine("El que es mayor es: " + num3);
                }
            }
        }
    }
}
