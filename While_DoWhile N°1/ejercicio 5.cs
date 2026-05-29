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
            string clave = "1234";
            string claveUsuario;

            do
            {
                Console.Write("Introduzca la contraseña: ");
                claveUsuario = Console.ReadLine();

                if (claveUsuario != clave)
                {
                    Console.WriteLine("Acceso Denegado");
                }

            } while (claveUsuario != clave);

            Console.WriteLine("Acceso Permitido");
        }
    }
}
