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
            float[] Productos = new float[10];
            int t = 1;
            int ProdDev;
            float Total = 0;
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Ingrese precio de proucto N°" + t + ": $");
                Productos[i] = float.Parse(Console.ReadLine());
                t++;
            }
            for (int i = 0; i < Productos.Length; i++)
            {
                Total += Productos[i];
            }
            Console.Write("Que producto ha sido devuelto: ");
            ProdDev = int.Parse(Console.ReadLine());
            Console.WriteLine("El precio del producto a devolver es de $" + Productos[ProdDev]);
            Console.WriteLine("El nuevo total es de $" + (Total - Productos[ProdDev]));
        }
    }
}