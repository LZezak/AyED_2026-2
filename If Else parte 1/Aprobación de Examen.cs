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

            Console.Write("Ingresa tu nota: ");
            double Nota = double.Parse(Console.ReadLine());

            if (Nota >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else if (Nota >= 4)
            {
                Console.WriteLine("A finales");
            }
            else if (Nota < 4)
            {
                Console.WriteLine("Recuperatorio");
            }
            

        }
    }
}