using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prendete_a_la_chiqui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cantidad total en minutos: ");
            int minutostotal = Convert.ToInt32(Console.ReadLine());

            int horas = minutostotal / 60;
            int minutos = minutostotal % 60;

            int costohora = horas * 6000;
            int costominutos = minutos * 150;
            int costototal = costohora + costominutos;

            double iva = costototal * 0.21;
            double totalfinal = costototal + iva;

            Console.WriteLine("El tiempo es de: " + horas + " horas y " + minutos + " minutos");
            Console.WriteLine("El costo sin IVA es de: $" + costototal);
            Console.WriteLine("IVA (21%): $" + iva);
            Console.WriteLine("El total apagar es de: $" + totalfinal);
        }
    }
}
