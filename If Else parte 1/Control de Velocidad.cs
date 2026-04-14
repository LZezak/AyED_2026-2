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
            Console.Write("Velocidad del vehiculo (km/h): ");
            int Respuesta = int.Parse(Console.ReadLine());

            if (Respuesta >= 120)
            {
                Console.WriteLine("Multa en camino: Exceso de velocidad");
            }
            else 
            {
                Console.WriteLine("Conducción segura");
            }
            

        }
    }
}