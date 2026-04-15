using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_15
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una cantidad de segundos: ");
        int segundos = Convert.ToInt32(Console.ReadLine());

        if (segundos > 60)
        {
            int minutos = segundos / 60;
            int resto = segundos % 60;

            Console.WriteLine(minutos + " minutos y " + resto + " segundos");
        }
        else
        {
            Console.WriteLine(segundos + " segundos");
        }
    }
}
}
