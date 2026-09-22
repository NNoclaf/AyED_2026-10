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
      static int suma = 0;
static int mayor = 0;
static int menor = 0;
static int par = 0;
static int impar = 0;

static void Main(string[] args)
{
    Console.Write("ponga la cantidad de numeros: ");
    int cantidad = int.Parse(Console.ReadLine());

    for (int i = 1; i <= cantidad; i++)
    {
        Console.Write("ponga un numero: ");
        int numero = int.Parse(Console.ReadLine());

        Suma(numero);
        Mayor(numero, i);
        Menor(numero, i);
        Par(numero);
        Impar(numero);
    }

    Promedio(cantidad);
}

static void Suma(int numero)
{
    suma = suma + numero;
    Console.WriteLine("la suma da: " + suma);
}

static void Mayor(int numero, int i)
{
    if (i == 1)
    {
        mayor = numero;
    }

    if (numero > mayor)
    {
        mayor = numero;
    }

    Console.WriteLine("el mayor es: " + mayor);
}

static void Menor(int numero, int i)
{
    if (i == 1)
    {
        menor = numero;
    }

    if (numero < menor)
    {
        menor = numero;
    }

    Console.WriteLine("el menor es: " + menor);
}

static void Par(int numero)
{
    if (numero % 2 == 0)
    {
        par++;
    }

    Console.WriteLine("la cantidad de pares son: " + par);
}

static void Impar(int numero)
{
    if (numero % 2 != 0)
    {
        impar++;
    }

    Console.WriteLine("la cantidad de impares son: " + impar);
}

static void Promedio(int cantidad)
{
    int promedio = suma / cantidad;

    Console.WriteLine("el promedio es: " + promedio);
}


}
    }
}


