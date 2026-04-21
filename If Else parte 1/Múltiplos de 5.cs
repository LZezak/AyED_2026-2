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
            Console.Write("Ingrese un número: ");
            int Número = int.Parse(Console.ReadLine());
            int Calculo = Número % 5;

            if (Calculo == 0)
            {
                Console.WriteLine(Número + " es divisible por 5.");
            }
            else
            {
                Console.WriteLine(Número + " no es divisible por 5.");
            }

        }
    }
}