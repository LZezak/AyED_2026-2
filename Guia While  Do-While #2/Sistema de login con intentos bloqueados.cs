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
            int Contraseña;
            string NombreUsuario;
            int ContraseñaCorrecta = 1234567;
            int Bandera = 1;
            int ContadorFallos = 0;
            string NombreUsuarioCorrecto = "EmperadorPalpatine66";
            do
            {
                Console.Write("Ingrese nombre de usuario: ");
                NombreUsuario = Console.ReadLine();
                Console.Write("Ingrese contraseña numerica: ");
                Contraseña = int.Parse(Console.ReadLine());
                if (NombreUsuario == NombreUsuarioCorrecto)
                {
                    if (Contraseña == ContraseñaCorrecta)
                    {
                        Console.WriteLine("Bienvenido al sistema");
                    }

                    else
                    {
                            ContadorFallos++;
                            Console.WriteLine("Nombre de usuario o contraseña incorrectos");
                        }
                }
                else
                {
                    ContadorFallos++;
                    Console.WriteLine("Nombre de usuario o contraseña incorrectos");
                }
                if(ContadorFallos == 3)
                {
                    Bandera = 0;
                    Console.WriteLine("Cuenta bloqueada por seguridad");
                }
               } while (Bandera != 0);

        }
    }
}
