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
            int Contador = 0;
            Console.Write("Ingrese un número entero positivo: ");
            int Numero = int.Parse(Console.ReadLine());
            for (int i = 2; i == Numero - 1; i++)
            {
                int Calculo = Numero % i;
                if (Calculo == 0)
                {
                    Contador = Contador + 1;
                }
            }
            if (Contador >= 2)
            {
                Console.WriteLine("No es primo");
            }
            else
            {
                Console.WriteLine("Es primo");

            }
            Console.WriteLine("Contador = " + Contador);
        }
    }
}
