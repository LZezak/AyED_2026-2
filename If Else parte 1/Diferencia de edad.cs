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
            Console.Write("Ingrese su edad hermano 1: ");
            int Hermano1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su edad hermano 2: ");
            int Hermano2 = int.Parse(Console.ReadLine());

            if (Hermano1 > Hermano2)
            {
                Console.WriteLine("Hermano 1 es el mayor");
                int CalculoDiferencia1 = Hermano1 - Hermano2;
                Console.WriteLine("Y es mayor por " + CalculoDiferencia1 + " años.");
            }
            else
            {
                Console.WriteLine("Hermano 2 es el mayor");
                int CalculoDiferencia2 = Hermano2 - Hermano1;
                Console.WriteLine("Y es mayor por " + CalculoDiferencia2 + " años.");
            }

        }
    }
}