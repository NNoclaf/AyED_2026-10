using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_6
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("El menu es:");
        Console.WriteLine("S. Sándwich");
        Console.WriteLine("P. Pizza");
        Console.WriteLine("H. Hamburguesa");

        Console.Write("Seleccione una letra: ");
        string opc = Console.ReadLine();

        switch (opc)
        {
            case "S":
                Console.WriteLine("Precio: $100");
                break;

            case "P":
                Console.WriteLine("Precio: $400");
                break;

            case "H":
                Console.WriteLine("Precio: $200");
                break;

            default:
                Console.WriteLine("Producto no encontrado");
                break;
        }
    }
}
}
