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
            Console.Write("Nombre: ");
            string Nombre = Console.ReadLine();
            Console.Write("Edad: ");
            int Edad = int.Parse(Console.ReadLine());

            if (Edad >= 18)
            {
                Console.WriteLine("Bienvenido al club, " + Nombre);
            }
            else 
            {
                Console.WriteLine("Lo siento, eres muy polluelo para esto");
            }
            

        }
    }
}