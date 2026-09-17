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
            Console.Write("Ingrese un número entero positivo para ver su descomposición en factores primos: ");
            int Numero = int.Parse(Console.ReadLine());
            FactoresPrimos(Numero);
        }
        static void FactoresPrimos(int Num)
        {
            int[] FactPrimos = new int[Num];
            int FactPrimosCant = 0;
            int Pos = 0;
            int i = 2;
            while (Num > 1)
            {
                if (Num % i == 0)
                {
                    Num = Num / i;
                    FactPrimosCant++;
                    FactPrimos[Pos] = i;
                    Pos++;
                }
                else
                {
                    i++;
                }
            }
            Console.Write("Los factores primos son: ");
            for (int p = 0; p < FactPrimosCant; p++)
            {
                Console.Write(FactPrimos[p] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Hay " + FactPrimosCant + " número primos");
        }
    }
}