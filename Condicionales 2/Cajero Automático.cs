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
            Console.Write("Ingrese el primer número: ");
            float Número1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            float Número2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            float Número3 = float.Parse(Console.ReadLine());

            if (Número1 > Número2)
            {
                if(Número1 > Número3)
                {
                    Console.WriteLine("El primero es el mayor");

                }
            }
            else if (Número1 > Número3)
            {
                if (Número1 > Número2)
                {
                    Console.WriteLine("El primero es el mayor");

                }
            }

            if (Número2 > Número1)
            {
                if (Número2 > Número3)
                {
                    Console.WriteLine("El segundo es el mayor");

                }
            }
            else if (Número2 > Número3)
            {
                if (Número2 > Número1)
                {
                    Console.WriteLine("El segundo es el mayor");

                }
            }

            if (Número3 > Número2)
            {
                if (Número3 > Número1)
                {
                    Console.WriteLine("El tercero es el mayor");

                }
            }
            else if (Número3 > Número1)
            {
                if (Número3 > Número2)
                {
                    Console.WriteLine("El tercero es el mayor");

                }
            }




        }
    }
}