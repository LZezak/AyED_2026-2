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
            double A;
            double B;

            Console.Write("Ingresa el primer número: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            B = Convert.ToInt32(Console.ReadLine());

            // SUMA
            double ResulSum;
            ResulSum = A + B;
            Console.WriteLine("El resultado de " + A + " + " + B + " = " + ResulSum);

            // RESTA
            double ResulRes;
            ResulRes = A - B;
            Console.WriteLine("El resultado de " + A + " - " + B + " = " + ResulRes);

            // MULTIPLICACIÓN
            double ResulMul;
            ResulMul = A * B;
            Console.WriteLine("El resultado de " + A + " x " + B + " = " + ResulMul);

            // DIVISIÓN
            double ResulDiv;
            ResulDiv = A / B;
            Console.WriteLine("El resultado de " + A + " / " + B + " = " + ResulDiv);
        }
    }
}
