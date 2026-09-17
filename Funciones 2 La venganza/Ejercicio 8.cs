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
            Console.WriteLine("Ingrese dos números y vea los números primos entre estos dos");
            Console.Write("Ingrese limite 1: ");
            int Limite1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese limite 2: ");
            int Limite2 = int.Parse(Console.ReadLine());
            FactoresPrimos(Limite1, Limite2);
        }
        static void FactoresPrimos(int Num1, int Num2)
        {
            int Min;
            int Max;
            if (Num1 > Num2)
            {
                Max = Num1;
                Min = Num2;
            }
            else
            {
                Max = Num2;
                Min = Num1;
            }
            int[] NumPrimos = new int[Max];
            int NumPrimosCant = 0;
            int Pos = 0;
            for (int i = Min; i <= Max; i++)
            {
                if (EsPrimo(i))
                {
                    NumPrimosCant++;
                    NumPrimos[Pos] = i;
                    Pos++;
                }
            }
            Console.Write("Los numeros primos entre " + Num1 + " y " + Num2 + " son: ");
            for (int p = 0; p < NumPrimosCant; p++)
            {
                Console.Write(NumPrimos[p] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Hay " + NumPrimosCant + " número primos");
        }
        static bool EsPrimo(int Num)
        {
            for (int i = 2; i <= Num - 1; i++)
            {
                if (Num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}