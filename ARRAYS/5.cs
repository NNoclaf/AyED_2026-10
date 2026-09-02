using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int producto = 0;
            int[] precio = new int[8];

            for (int i =0; i < precio.Length; i++)
            {
                Console.Write("escriba cuanto vale el producto: ");
                precio[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("ponga cuanto dinero hay: ");
            int dinero = int.Parse(Console.ReadLine());

            for (int i =0; i < precio.Length; i++)
            {
                if (precio[i]<= dinero)
                {
                    producto++;
                }
            }
            Console.WriteLine("se puede comprar " + producto + " productos");
        }
    }
}
