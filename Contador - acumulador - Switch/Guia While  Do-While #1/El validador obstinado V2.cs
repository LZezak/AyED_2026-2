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
            Console.Write("Ingrese la correcta nota de su examen: ");
            int Nota = int.Parse(Console.ReadLine());
            while (Nota < 1 || Nota > 10)
            {
                Console.WriteLine("ERROR");
                Console.Write("Intente de nuevo: ");
                Nota = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Su nota es: " + Nota);
        }
    }
}

