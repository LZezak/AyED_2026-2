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
            Console.Write("Ingrese el número para sacar su facorial: ");
            Numero = int.Parse(Console.ReadLine());
            Factorial(Numero);
        }
        static void Factorial(int Num)
        {
            int Total = 0;
            int NumMensaje = Num;
            Total = Num * (Num - 1);
            Num = Num - 2;
            while (Num != 0)
            {
                Total = Total * (Num);
                Num--;
            }
            Console.WriteLine("El resultado del factorial de " + NumMensaje + " es: " + Total);
        }
    }
}