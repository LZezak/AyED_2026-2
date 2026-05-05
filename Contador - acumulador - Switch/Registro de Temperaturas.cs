using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Acumulador = 0;
            int Contador = 0;
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("Ingrese la temperatura del dia " + i + ": ");
                int Temp = int.Parse(Console.ReadLine());
                Acumulador = Acumulador + Temp;
                if (Temp < 0)
                {
                    Contador = Contador + 1;
                }

            }
            Console.WriteLine("La temperatura sumada fue: " + Acumulador + " grados.");
            Console.WriteLine("La temperatura fue menor a 0 grados un total de " + Contador + " veces.");

        }
    }
}
