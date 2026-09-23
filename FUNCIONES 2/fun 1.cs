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
        int cantidad;
            int numero;
            int mayor = 0;
            int menor = 0;
            int suma = 0;
            int par = 0;
            int impar = 0;

            Console.Write("ponga la cantidad de numeros: ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("ponga un numero: ");
                numero = int.Parse(Console.ReadLine());

                suma = suma + numero;

                if (i == 1)
                {
                    mayor = numero;
                    menor = numero;
                }
                else
                {
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }

                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }

                if (numero % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }

            Mayor(mayor);
            Menor(menor);
            Promedio(suma, cantidad);
            Par(par);
            Impar(impar);
        }

        static void Mayor(int mayor)
        {
            Console.WriteLine("el mayor es: " + mayor);
        }

        static void Menor(int menor)
        {
            Console.WriteLine("el menor es: " + menor);
        }

        static void Promedio(int suma, int cantidad)
        {
            double promedio = (double)suma / cantidad;
            Console.WriteLine("el promedio es: " + promedio);
        }

        static void Par(int par)
        {
            Console.WriteLine("la cantidad de pares: " + par);
        }

        static void Impar(int impar)
        {
            Console.WriteLine("la cantidad de impares: " + impar);
        }
    }
}
