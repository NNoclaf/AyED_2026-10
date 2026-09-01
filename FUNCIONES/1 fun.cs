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
        Console.Write("ponga un numero: ");
        int e = int.Parse(Console.ReadLine());
        ContarRegresivo(e);
    }

    static float ContarRegresivo(int n)
    {
        for (int i = n; i > 0; i--)
        {
            Console.WriteLine("" + n + "");
            n--;
        }
        return n;
            
}
}
}
