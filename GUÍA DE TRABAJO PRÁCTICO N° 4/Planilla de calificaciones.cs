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
            double[] Nota = new double[10];
            double t = 1;
            double Desaprobados = 0;
            double Aprobados = 0;
            double Total = 0;
            double Promedio;
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Ingrese nota del alumno " + t + ": ");
                Nota[i] = int.Parse(Console.ReadLine());
                if (Nota[i] > 0 && Nota[i] <= 10)
                {
                    t++;
                }
                else
                {
                    i--;
                    Console.WriteLine("Valor de nota no valido, intente de nuevo");
                }

            }
            for (int i = 0; i < Nota.Length; i++)
            {
                Total += Nota[i];
                if (Nota[i] <= 10 && Nota[i] >= 6)
                {
                    Aprobados++;
                }
                else if (Nota[i] > 0 && Nota[i] <= 5)
                {
                    Desaprobados++;
                }
            }
            Promedio = Total / Nota.Length;
            Console.WriteLine("La cantidad de aprobados fue: " + Aprobados);
            Console.WriteLine("La cantidad de desaprobados fue: " + Desaprobados);
            Console.WriteLine("El promedio del curso fue: " + Promedio);
        }
    }
}
