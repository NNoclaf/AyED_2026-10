using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int baja = 412;
            int alta = 0;
            int[] temperatura = new int[7];
            for (int i =0; i < temperatura.Length; i++)
            {
                Console.Write("Igrese la temperatura q va a aser hoy: ");
                temperatura[i] = int.Parse(Console.ReadLine());
                suma = suma + temperatura[i];
                if (temperatura[i] < baja)
                {
                    baja = temperatura[i];
                }
                if (temperatura[i] > alta)
            {
                alta = temperatura[i];
            }
            }
        int promedio = suma / 7;
        Console.WriteLine("la temraturamas bas baja de cesta semana es de " + baja+ " grados, y la mas alta de la semanaes dec" + alta + " grados y el promedio es de " +promedio);  
        }
    }
}
