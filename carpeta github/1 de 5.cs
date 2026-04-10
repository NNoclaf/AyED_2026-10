using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el peso de la nave en kg: ");
            int peso = Convert.ToInt32(Console.ReadLine());

            if (peso <= 5000)
            {
                Console.WriteLine("Despegue autorizado.Buen viaje, Mando");
            }
            else
            {
                int exceso = peso - 5000;
                Console.WriteLine("Alerta: Exceso de peso.Debes descargar " + exceso + " kg para despegar");
            }
        }
    }
}
