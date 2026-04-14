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

            Console.Write("Escribe un número: ");
            float Número = float.Parse(Console.ReadLine());

            if (Número % 2 == 0)
            {
                Console.WriteLine("Es par.");
            }
            else 
            {
                Console.WriteLine("Es impar.");
            }
            

        }
    }
}