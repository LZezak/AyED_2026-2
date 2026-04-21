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
            Console.Write("Ingrese temperatura actual: ");
            int Temperatura = int.Parse(Console.ReadLine());

            if (Temperatura <= 0)
            {
                Console.WriteLine("Peligro de congelamiento");
            }
            if (Temperatura > 0)
            {
                if(Temperatura < 15)
                Console.WriteLine("Mucho frío");
            }
            if(Temperatura > 15)
            {
                Console.WriteLine("Clima agradable");
            }


        }
    }
}