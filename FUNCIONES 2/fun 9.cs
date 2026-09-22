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
      


}
    }
}


