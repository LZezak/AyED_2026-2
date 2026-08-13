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
            float[] TiemposCorredores = new float[6];
            int t = 1;
            float MejorTiempo = 999;
            float PeorTiempo = 0;
            for (int i = 0; i <= 5; i++)
            {
                Console.Write("Ingrese tiempo (en segundos) del corredor N°" + t + ": ");
                TiemposCorredores[i] = float.Parse(Console.ReadLine());
                t++;
            }
            for (int i = 0; i < TiemposCorredores.Length; i++)
            {
                if (TiemposCorredores[i] < MejorTiempo)
                {
                    MejorTiempo = TiemposCorredores[i];
                }
                if (TiemposCorredores[i] > PeorTiempo)
                {
                    PeorTiempo = TiemposCorredores[i];
                }
            }
            for (int i = 0; i < TiemposCorredores.Length; i++)
            {
                if (TiemposCorredores[i] == MejorTiempo)
                {
                    Console.WriteLine("El corredor " + (i + 1) + " es el ganador con un tiempo de " + MejorTiempo + " segundos");
                }
                if (TiemposCorredores[i] == PeorTiempo)
                {
                    Console.WriteLine("El corredor " + (i + 1) + " es el perdedor con un tiempo de " + PeorTiempo + " segundos"); ;
                }
            }
        }
    }
}