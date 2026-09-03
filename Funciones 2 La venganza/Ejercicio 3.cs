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
            Console.Write("Ingrese el número entero 1: ");
            int Numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número entero 2: ");
            int Numero2 = int.Parse(Console.ReadLine());
            EntreNumeros(Numero1, Numero2);
        }
        static void EntreNumeros(int Num1, int Num2)
        {
            int Inicio = 0;
            int Final = 0;
            int Par = 0;
            int Impar = 0;
            int Suma = 0;
            if (Num1 > Num2)
            {
                Inicio = Num1;
                Final = Num2;
            }
            else
            {
                Inicio = Num2;
                Final = Num1;
            }
            for (int i = Inicio; i != (Final - 1); i--)
            {
                Inicio--;
                Console.Write(Inicio + "  ");
                if ((Inicio % 2) == 0)
                {
                    Par++;
                }
                else
                {
                    Impar++;
                }
                Suma = Suma + Inicio;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Hay " + Par + " números pares");
            Console.WriteLine("Hay " + Impar + " números impares");
            Console.WriteLine("La suma de todos los números mostrados es " + Suma);
        }
    }
}
