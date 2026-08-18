using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Reseñas = new int[25];
            int[] Estrellas = { 0, 0, 0, 0, 0 };
            for (int i = 0; i < Reseñas.Length; i++)
            {
                Console.Write("Ingrese calificación (1-5): ");
                Reseñas[i] = int.Parse(Console.ReadLine()) - 1;
                if (Reseñas[i] > 5 || Reseñas[i] < 0)
                {
                    Console.WriteLine("Respuesta no valida, intente de nuevo");
                    i--;
                }
                else
                {
                    Estrellas[(Reseñas[i])] = Estrellas[(Reseñas[i])] + 1;
                }
            }
            for (int i = 0; i < Estrellas.Length; i++)
            {
                Console.WriteLine("Se calificaron con " + (i + 1) + " estrellas unas " + (Estrellas[i]) + " veces.");

            }
        }
    }
}
