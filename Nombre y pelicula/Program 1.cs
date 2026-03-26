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

            Console.WriteLine("Hola Usuario");
            Console.Write("¿Cual es tu nombre?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tu pelicula favorita?: ");
            pelicula = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ". " + "Tu pelicula favorita " + pelicula + " es una porqueria");


        }
    }
}
