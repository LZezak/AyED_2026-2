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
            Console.Write("Ingrese su promedio: ");
            float Promedio = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la distancia de su casa a la facultad (km): ");
            float Distancia = float.Parse(Console.ReadLine());

            if (Promedio > 8)
            {
                Console.WriteLine("Beca concedida");
            }
            else if (Distancia > 50)
            {
                Console.WriteLine("Beca concedida");
            }



        }
    }
}