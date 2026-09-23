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
      int numero;
        int original;
        int invertido = 0;
        int cantidad = 0;

        Console.Write("ponga un numero entero: ");
        numero = int.Parse(Console.ReadLine());

        original = numero;

        if (numero < 0)
        {
            numero = numero * -1;
            original = numero;
        }

        do
        {
            cantidad++;
            int digito = numero % 10;
            invertido = invertido * 10 + digito;
            numero = numero / 10;
        }
        while (numero > 0);

        Mostrar(cantidad, original, invertido);
    }

    static void Mostrar(int cantidad, int original, int invertido)
    {
        Console.WriteLine("la cantidad de digitos es: " + cantidad);

        if (original == invertido)
        {
            Console.WriteLine("el numero es capicua");
        }
        else
        {
            Console.WriteLine("el numero no es capicua");
        }
    }
}
