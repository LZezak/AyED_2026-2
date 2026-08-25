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
            int Numero;
            Console.Write("Ingrese el número inicial: ");
            Numero = int.Parse(Console.ReadLine());
            Console.WriteLine(Numero);
            ContarRegresivo(Numero);
        }
        static void ContarRegresivo(int Num)
        {
            while (Num != 1)
            {
                Console.WriteLine(Num - 1);
                Num--;
            }
        }
    }
}
