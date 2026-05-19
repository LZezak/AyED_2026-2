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
            Console.Write("Ingrese un número entero positivo: ");
            int Numero = int.Parse(Console.ReadLine());
            int Multiplicador = 1;
            Console.WriteLine("TABLA DEL " + Numero);
            while (Multiplicador <= 12)
            {
                Console.WriteLine(Multiplicador + " x " + Numero + " = " + (Numero * Multiplicador));
                Multiplicador++;
            }

        }
    }
}
