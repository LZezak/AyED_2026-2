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
            int[] Edades = new int[12];
            int t = 1;
            int Menores = 0;
            int AdultMayores = 0;
            int Intermedio = 0;
            for (int i = 0; i <= 11; i++)
            {
                Console.Write("Ingrese la edad de la perona " + t + ": ");
                Edades[i] = int.Parse(Console.ReadLine());
                if (Edades[i] > 0)
                {
                    t++;
                }
                else
                {
                    i--;
                    Console.WriteLine("Edad no valida, intente de nuevo");
                }
            }
            for (int i = 0; i < Edades.Length; i++)
            {
                if (Edades[i] >= 0 && Edades[i] < 18)
                {
                    Menores++;
                }
                else if (Edades[i] >= 65)
                {
                    AdultMayores++;
                }
                else
                {
                    Intermedio++;
                }
            }
            Console.WriteLine("Hay " + Menores + " personas menores de edad");
            Console.WriteLine("Hay " + AdultMayores + " personas que son adultos mayores");
            Console.WriteLine("Hay " + Intermedio + " personas en edad intermedia");
        }
    }
}