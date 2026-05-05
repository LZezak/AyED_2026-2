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
            Console.WriteLine("Seleccione un idioma / Select a language /");
            Console.WriteLine("Sélectionnez une langue / Wählen Sie eine Sprache aus:");
            Console.WriteLine("(S)ándwich");
            Console.WriteLine("(P)izza");
            Console.WriteLine("(H)amburguesa");
            Console.Write("¿Que va a comer hoy?: ");

            String opción = Console.ReadLine();

            switch (opción)
            {
                case "S":
                    Console.WriteLine("Eligió Sándwich. El precio es de $5.000");
                    break;
                case "P":
                    Console.WriteLine("Eligió Pizza. El precio es de $15.000");
                    break;
                case "H":
                    Console.WriteLine("Eligió Hamburguesa. El precio es de $3.700");
                    break;
                default:
                    Console.WriteLine("Producto no encontrado.");
                    break;
            }
        }
    }
}
