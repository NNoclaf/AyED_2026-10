using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("ponga la cantidad de numeros: ");
        int cantida = int.Parse(Console.ReadLine());
        mostrar(cantida);

    }
        static void mostrar(int cantida)
        {
            int suma = 0;
            int menor = 0;
            int mayor = 0;
            int par = 0;
            int impar = 0;

            for (int i = 1; i < cantida; i++)

            {
                Console.Write("ponga un numero: ");
                int numero = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    mayor = numero;
                    menor = numero;
                }
                if (numero > mayor)
                {
                    mayor = numero;
                }
                if (numero < menor)
                {
                    menor = numero;
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
            int promedio = suma / cantida;

            Console.WriteLine(" el numero mayor es: " + mayor);
            Console.WriteLine(" el menor numero es : " + menor);
            Console.WriteLine(" los numeros pares son: " + par);
            Console.WriteLine(" los numros impar son: " + impar);
            Console.WriteLine(" el promediode todo es: " + promedio);
      


}using System;

class Program
{
    static void Main()
    {
        int cantidad;
        int numero;
        int positivos = 0;
        int negativos = 0;
        int ceros = 0;
        int sumaPosi = 0;
        int sumaNega = 0;

        Console.Write("ponga la cantidad de numeros: ");
        cantidad = int.Parse(Console.ReadLine());

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("ponga un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                positivos++;
                sumaPosi = sumaPosi + numero;
            }
            else if (numero < 0)
            {
                negativos++;
                sumaNega = sumaNega + numero;
            }
            else
            {
                ceros++;
            }
        }

        MostrarResultados(positivos, negativos, ceros, sumaPosi, sumaNega);
    }

    static void MostrarResultados(int positivos, int negativos, int ceros, int sumaPosi, int sumaNega)
    {
        Console.WriteLine("positivos: " + positivos);
        Console.WriteLine("negativos: " + negativos);
        Console.WriteLine("ceros: " + ceros);

        if (positivos > 0)
        {
            Console.WriteLine("el promedio de positivos son: " + (double)sumaPosi / positivos);
        }

        if (negativos > 0)
        {
            Console.WriteLine("el promedio de  negativos es: " + (double)sumaNega / negativos);
        }
    }
}
    }
