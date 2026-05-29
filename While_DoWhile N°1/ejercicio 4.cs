using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_4
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un numero:");
        int num = int.Parse(Console.ReadLine());
        int multi = 0;
        int nume = 0;
        while (nume < (num * 12)) 
        {

            nume = num * multi;
            multi++;
            Console.WriteLine(+nume +"");
        }
}
}
}

