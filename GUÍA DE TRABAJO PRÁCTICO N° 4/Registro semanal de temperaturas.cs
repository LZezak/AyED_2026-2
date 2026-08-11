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
            double[] Temp = new double[7];
            int t = 1;
            double Total = 0;
            double TempMax = 0;
            double TempMin = 9999999999999999999;
            double Promedio;
            for(int i = 0; i <= 6; i++)
            {
                Console.Write("Ingrese temperatura del dia " + t + ": ");
                Temp[i] = double.Parse(Console.ReadLine());
                t++;
            }
            for (int i = 0; i < Temp.Length; i++)
            {
                Total += Temp[i];
                if (Temp[i] > TempMax)
                {
                    TempMax = Temp[i];
                }
                if (Temp[i] < TempMin)
                {
                    TempMin = Temp[i];
                }
            }
            Promedio = Total / Temp.Length;
            Console.WriteLine("La teperatura mas alta fue: " + TempMax);
            Console.WriteLine("La teperatura mas baja fue: " + TempMin);
            Console.WriteLine("La teperatura promedio fue: " + Promedio);
        }
    }
}
