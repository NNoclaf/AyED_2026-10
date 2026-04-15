using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_14
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese su sueldo: ");
        double sueldo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese los años de antiguedad: ");
        int antiguedad = Convert.ToInt32(Console.ReadLine());

        double sueldonuevo;

        if (antiguedad > 10)
        {
            sueldonuevo = sueldo + (sueldo * 0.20);
        }
        else
        {
            sueldonuevo = sueldo + (sueldo * 0.05);
        }

        Console.WriteLine("El sueldo nuevo es de: $" + sueldonuevo);
    }
}
}
