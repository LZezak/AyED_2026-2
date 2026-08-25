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
            Console.Write("Ingrese el número final: ");
            Numero = int.Parse(Console.ReadLine());
            ContarHasta(Numero);
        }
        static void ContarHasta(int Num)
        {
            int r = 0;
            while (r != Num)
            {
                Console.WriteLine(r + 1);
                r++;
            }
        }
    }
}
