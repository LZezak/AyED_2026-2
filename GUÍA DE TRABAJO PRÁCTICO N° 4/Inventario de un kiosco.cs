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
            int[] Productos = new int[8];
            int Monto;
            int t = 1;
            for (int i = 0; i <= 7; i++)
            {
                Console.Write("Ingrese precio del producto " + t + ": $");
                Productos[i] = int.Parse(Console.ReadLine());
                t++;
            }
            t = 1;
            Console.Write("Ingrese monto: $");
            Monto = int.Parse(Console.ReadLine());
            for (int i = 0; i < Productos.Length; i++)
            {
                 Console.WriteLine("Usted puede comprar " + (Monto/Productos[i]) + " del producto " + t);
                 t++;
            }
        }
    }
}
