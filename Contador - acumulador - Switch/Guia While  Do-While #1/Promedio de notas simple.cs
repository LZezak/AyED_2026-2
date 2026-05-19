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
            float Temp = float.Parse(Console.ReadLine());
            while (Temp >= 23)
            {
                Console.WriteLine("Enfriando...Temperatura actual: " + Temp + "°C");
                Temp = Temp - 2;
            }
            Console.WriteLine("Temperatura ideal alcanzada");
            



        }
    }
}