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
            Console.Write("Ingrese un número entero positivo para determinar si es perfecto: ");
            int Numero = int.Parse(Console.ReadLine());
            DeterminarNumPerfecto(Numero);
        }
        static void DeterminarNumPerfecto(int Num)
        {
            int NumOriginal = Num;
            int Suma = 0;
            for (int i = Num; i != 1; i--)
            {
                Num--;
                if (NumOriginal % Num == 0)
                {
                    Suma = Suma + Num;
                }
            }
            if (Suma == NumOriginal)
            {
                Console.WriteLine(NumOriginal + " si es un número perfecto");
            }
            else
            {
                Console.WriteLine(NumOriginal + " no es un número perfecto");
            }
        }
    }
}
