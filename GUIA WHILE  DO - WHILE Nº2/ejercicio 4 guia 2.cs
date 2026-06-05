using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuarioCorrecto = "admin";
            string contraCorrecta = "1234";

            int intentos = 0;

            while (intentos < 3)
            {
                Console.Write("Ingrese su usuario: ");
                string usuario = Console.ReadLine();

                Console.Write("Ingrese su contraseña: ");
                string contraseña = Console.ReadLine();

                if (usuario == usuarioCorrecto && contraseña == contraCorrecta)
                {
                    Console.WriteLine("Bienvenido al sistema");
                    break;
                }

                intentos++;
            }

            if (intentos == 3)
            {
                Console.WriteLine("Cuenta bloqueada por seguridad");
            }
        }
    }
}
