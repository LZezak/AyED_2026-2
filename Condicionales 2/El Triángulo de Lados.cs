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
            Console.Write("Ingrese su peso (kg): ");
            float Peso = float.Parse(Console.ReadLine());
            Console.Write("Ingrese su altura (m): ");
            float Altura = float.Parse(Console.ReadLine());
            float IMC = Peso / (Altura * Altura);

            Console.WriteLine("Su IMC es igual a " + IMC);
            if (IMC > 25)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Rango normal");
            }



        }
    }
}