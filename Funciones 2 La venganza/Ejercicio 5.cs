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
            Console.Write("Ingrese un número para determinar si es capicua: ");
            string Numero = Console.ReadLine();
            Operaciones(Numero);

        }
        static void Operaciones(string Num)
        {
            string NumOriginal = Num;
            int CantDigit = Num.ToString().Length;
            char[] arreglo = Num.ToCharArray();
            Array.Reverse(arreglo);
            string Invertido = new string(arreglo);
            Console.WriteLine("El número tiene " + CantDigit + " digitos");
            if (NumOriginal == Invertido)
            {
                Console.WriteLine("El número es capicua");
            }
            else
            {
                Console.WriteLine("El número no es capicua");
            }
        }
    }
}