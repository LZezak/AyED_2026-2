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
            int[] Sucursal_1 = new int[5];
            int[] Sucursal_2 = new int[5];
            int t = 1;
            int VentasS1 = 0;
            int VentasS2 = 0;
            Console.WriteLine("Sucursal 1");
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Ingrese monto del dia " + t + ": $");
                Sucursal_1[i] = int.Parse(Console.ReadLine());
                t++;
            }
            t = 1;
            Console.WriteLine("Sucursal 2");
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Ingrese monto del dia " + t + ": $");
                Sucursal_2[i] = int.Parse(Console.ReadLine());
                t++;
            }
            t = 1;
            for (int i = 0; i < Sucursal_1.Length; i++)
            {
                VentasS1 += Sucursal_1[i];
                VentasS2 += Sucursal_2[i];
                if (Sucursal_1[i] > Sucursal_2[i])
                {
                    Console.WriteLine("El dia " + t + " la sucrusal 1 vendio mas que la 2");
                }
                else if (Sucursal_2[i] > Sucursal_1[i])
                {
                    Console.WriteLine("El dia " + t + " la sucrusal 2 vendio mas que la 1");
                }
                else
                {
                    Console.WriteLine("El dia " + t + " las dos sucursales vendieron lo mismo");
                }
            }
            if (VentasS1 > VentasS2)
            {
                Console.WriteLine("En la semana la sucursal 1 vendio mas que la 2");
            }
            else if (VentasS2 > VentasS1)
            {
                Console.WriteLine("En la semana la sucursal 2 vendio mas que la 1");
            }
            else
            {
                Console.WriteLine("El la semana las dos sucursales vendieron lo mismo");
            }
        }
    }
}