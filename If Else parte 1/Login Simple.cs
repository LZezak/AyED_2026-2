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
            Console.Write("Ingrese nombre de usuario: ");
            string Usuario = Console.ReadLine();
            Console.Write("Ingrese contraseña: ");
            int Contraseña = int.Parse(Console.ReadLine());

            if (Usuario == "admin")
            {
                if (Contraseña == 1234)
                { 
                Console.WriteLine("Acceso concedido");
                }
            }
            else
            {
                Console.WriteLine("Error de credenciales");
            }


        }
    }
}