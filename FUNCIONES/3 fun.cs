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
            Console.Write("pona un numero: ");
            int e = int.Parse(Console.ReadLine());
            SumarHasta(e);
        }
        static void SumarHasta(int p)
        {
            int n = 0;
            for (int i = 0; i < p; i++)
            {
                n = p * i;
                n = n + p;
                Console.WriteLine("" + n + "");
            }

        }
    }
}
