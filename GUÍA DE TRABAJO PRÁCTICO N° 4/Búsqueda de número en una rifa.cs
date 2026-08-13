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
            int[] Productos = new int[15];
            int t = 1;
            int Num_elegido;
            for (int i = 0; i <= 14; i++)
            {
                Console.Write("Ingrese número " + t + " de la rifa: ");
                Productos[i] = int.Parse(Console.ReadLine());
                t++;
            }
            Console.Write("Ingrese el número del que desea conocer el estado: ");
            Num_elegido = int.Parse(Console.ReadLine());
            for (int i = 0; i < Productos.Length; i++)
            {
                if (Productos[i] == Num_elegido)
                {
                    Console.WriteLine("El número que usted eligio no esta disponible");
                    i = Productos.Length;
                }
                else
                {
                    Console.WriteLine("El número que usted eligio si esta disponible");
                    i = Productos.Length;
                }
            }
        }
    }
}