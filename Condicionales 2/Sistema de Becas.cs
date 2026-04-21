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
            Console.Write("Ingrese su saldo actual: ");
            float Saldo = float.Parse(Console.ReadLine());
            Console.Write("Ingrese cuanto dinero desea retirar: ");
            float Retiro = float.Parse(Console.ReadLine());
            float Calculo = Retiro % 1000;

            if (Retiro > Saldo)
            {
                Console.WriteLine("Fondos insuficientes");
            }
            if (Retiro < Saldo)
            {
                if (Calculo == 0)
                {
                    Console.WriteLine("Operación permitida");
                }
                else
                {
                    Console.WriteLine("Operación no permitida");
                    Console.WriteLine("Solo billetes de 1000");
                }
            }



        }
    }
}