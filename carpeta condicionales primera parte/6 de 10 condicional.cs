using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_de_10_condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre de usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Ingrese la contraseña: ");
            string contra = Console.ReadLine();

            if (usuario == "admin")
            {
                if (contra == "1234")
                {
                    Console.WriteLine("Acceso concedido");
                }
                else
                {
                    Console.WriteLine("Error de credenciales");
                }
            }
            else
            {
                Console.WriteLine("Error de credenciales");
            }
        }
    }
}
