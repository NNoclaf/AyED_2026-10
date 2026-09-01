using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ponga un numerito: ");
            int e = int.Parse(Console.ReadLine());
            ContarHasta(e);
        }
        static void ContarHasta (int m)
        {
            for (int i = 1; i<= m; i++)
            {
                Console.WriteLine("" + i +"");
            }
        }
    }
    }

