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
            string[] Clases = new string[20];
            int t = 1;
            int Inasistencias = 0;
            for (int i = 0; i <= 19; i++)
            {
                Console.Write("El alumno estuvo presente o ausente en la clase " + t + " (P/A): ");
                Clases[i] = Console.ReadLine();
                t++;
                if (Clases[i] != "P" && Clases[i] != "A")
                {
                    i--;
                    t--;
                    Console.WriteLine("Valor de nota no valido, intente de nuevo");
                }
            }
            for (int i = 0; i < Clases.Length; i++)
            {
                if (Clases[i] == "A")
                {
                    Inasistencias++;
                }
            }
            Console.WriteLine("La cantidad inasistencias fue: " + Inasistencias);
            if(Inasistencias <= 6)
            {
                Console.WriteLine("Debido a las " + Inasistencias + " inasistencias el alumno permanece regular");
            }
            else
            {
                Console.WriteLine("Debido a las " + Inasistencias + " inasistencias el alumno queda libre");

            }
        }
    }
}
