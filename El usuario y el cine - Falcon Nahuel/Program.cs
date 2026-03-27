using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_usuario_y_el_cine___Falcon_Nahuel
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String pelicula;

            Console.WriteLine("Hola");
            Console.Write("Como te llamas?: ");
            nombre = Console.ReadLine();
            Console.Write("Cual es tu pelicula favorita?: ");
            pelicula = Console.ReadLine();

         
            Console.WriteLine("Hola "  +  nombre);
            Console.WriteLine("Tu pelicula preferida " + pelicula + " es una porqueria");
        }
    }
}
