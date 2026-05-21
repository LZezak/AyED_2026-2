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
            int eleccion;
            do
            {
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Despedirse");
                Console.WriteLine("3. Salir");
                Console.Write("Elija: ");
                eleccion = int.Parse(Console.ReadLine());
                if (eleccion == 1)
                {
                    Console.WriteLine("Hola");
                }
                else if (eleccion == 2)
                {
                    Console.WriteLine("Adios");
                }
                else
                {
                    Console.WriteLine("La respuesta ingresada no es valida");
                    Console.WriteLine("Intente de nuevo");
                }

            } while (eleccion != 3);
            
        }
    }
}
