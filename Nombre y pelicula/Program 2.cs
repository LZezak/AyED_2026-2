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
            String nombre;
            String pelicula;
            String consola;

            Console.WriteLine("Hola Usuario");
            Console.Write("¿Cual es tu nombre?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tu juego favorito?: ");
            pelicula = Console.ReadLine();
            Console.Write("¿En que consola se juega?: ");
            consola = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ". " + "Tu juego favorito es " + pelicula + " y se juega en " + consola + ".");


        }
    }
}
