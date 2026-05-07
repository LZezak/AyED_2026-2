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
            int PrimerDivisor = 0;
            Console.Write("Ingrese un número entero positivo: ");
            int Numero = int.Parse(Console.ReadLine());
            if(Numero <= 0)
            {
                Console.WriteLine("El 1 e inferiores no son números primos");
            }
            else
            {
                for (int i = 2; i <= Numero - 1; i++)
                {
                    if (Numero % i == 0)
                    {
                        PrimerDivisor = i;
                        break;
                    }
                }
            }
            if (PrimerDivisor == 0)
            {
                Console.WriteLine(Numero + " es primo");
            }
            else
            {
                Console.WriteLine(Numero + " no es primo");
                Console.WriteLine("El primer divisor encontrado fue el número " + PrimerDivisor);
            }
        }
    }
}
