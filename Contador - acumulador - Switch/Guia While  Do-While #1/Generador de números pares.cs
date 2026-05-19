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
            Console.Write("Ingrese el límite de números pares a generar: ");
            int Limite = int.Parse(Console.ReadLine());
            while (Limite >= 0)
            {
                if((Limite%2) == 0)
                Console.WriteLine(Limite);
                Limite--;
            }

        }
    }
}