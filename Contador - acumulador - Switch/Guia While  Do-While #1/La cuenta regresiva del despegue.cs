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
            Console.Write("Ingrese un número entero: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("LANZAMIENTO EN: ");
            while (Numero >= 0)
            {
                Console.WriteLine(Numero);
                Numero--;
            }

        }
    }
}
