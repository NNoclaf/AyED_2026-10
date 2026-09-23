using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
class Program
{
static void Main(string[] args)
{
int numero1;
    int numero2;

    Console.Write("ponga el primer numero: ");
    numero1 = int.Parse(Console.ReadLine());

    Console.Write("ponga el segundo numero: ");
    numero2 = int.Parse(Console.ReadLine());

    MostrarNumeros(numero1, numero2);

    Console.WriteLine("la cantidad de pares es: " + ContarPares(numero1, numero2));
    Console.WriteLine("la cantidad de impares es: " + ContarImpares(numero1, numero2));
    Console.WriteLine("toda la suma de los valores da: " + SumarNumeros(numero1, numero2));
}

static void MostrarNumeros(int numero1, int numero2)
{
    int menor = numero1;
    int mayor = numero2;

    if (numero2 < numero1)
    {
        menor = numero2;
        mayor = numero1;
    }

    for (int i = menor; i <= mayor; i++)
    {
        Console.WriteLine(i);
    }
}

static int Pares(int numero1, int numero2)
{
    int cantidad = 0;
    int menor = numero1;
    int mayor = numero2;

    if (numero2 < numero1)
    {
        menor = numero2;
        mayor = numero1;
    }

    for (int i = menor; i <= mayor; i++)
    {
        if (i % 2 == 0)
        {
            cantidad++;
        }
    }

    return cantidad;
}

static int Impares(int numero1, int numero2)
{
    int cantidad = 0;
    int menor = numero1;
    int mayor = numero2;

    if (numero2 < numero1)
    {
        menor = numero2;
        mayor = numero1;
    }

    for (int i = menor; i <= mayor; i++)
    {
        if (i % 2 != 0)
        {
            cantidad++;
        }
    }

    return cantidad;
}

static int Suma(int numero1, int numero2)
{
    int suma = 0;
    int menor = numero1;
    int mayor = numero2;

    if (numero2 < numero1)
    {
        menor = numero2;
        mayor = numero1;
    }

    for (int i = menor; i <= mayor; i++)
    {
        suma = suma + i;
    }

    return suma;
}

}
}


