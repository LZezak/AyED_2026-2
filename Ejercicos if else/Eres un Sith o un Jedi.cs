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
            Console.WriteLine("Encuentras un cristal Kyber perdido. ¿Qué haces?: ");
            Console.WriteLine("1. Lo devuelves al templo.");
            Console.WriteLine("2. Lo vendes por créditos.");
            Console.WriteLine("3. Lo usas para construir un arma roja.");
            Console.Write("¿Que eliges?: ");

            int Respuesta = int.Parse(Console.ReadLine());

            if (Respuesta == 1)
            {
                Console.WriteLine("El camino del Jedi sigue.");
            }
            else if (Respuesta == 2)
            {
                Console.WriteLine("Un cazarrecompensas eres.");
            }
            else if (Respuesta == 3)
            {
                Console.WriteLine("El Lado Oscuro se apodera de ti.");
            }
            else
            {
                Console.WriteLine("Error en la Fuerza: te falta IQ, opción inválida.");
            }


        }
    }
}