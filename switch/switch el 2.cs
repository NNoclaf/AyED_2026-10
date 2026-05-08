using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_2
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Ingrese una calificacion segun la siguiente lista:");
Console.WriteLine("(1)A. Excelente");
Console.WriteLine("(2)B. Bueno");
Console.WriteLine("(3)C. Regular");
Console.WriteLine("(4)D. Suficiente");
Console.WriteLine("(5)F. Reprobado");

Console.Write("Coloque la opcion deseada: ");

int opc = int.Parse(Console.ReadLine());

switch (opc)
{
    case 1:
        Console.WriteLine("La opcion que se eligio es Excelente");
        break;
    case 2:
        Console.WriteLine("La opcion que se eligio es Bueno");
        break;
    case 3:
        Console.WriteLine("La opcion que se eligio es Regular");
        break;
    case 4:
        Console.WriteLine("La opcion que se eligio es Suficiente");
        break;
    case 5:
        Console.WriteLine("La opcion que se eligio es Reprobado");
        break;
    default:
        Console.WriteLine("La opcion que se eligio no es valida");
        break;
}
}
}
}
