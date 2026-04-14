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


            Console.Write("Distancia del destino (años luz): ");
            int AñosLuz = int.Parse(Console.ReadLine());
            Console.Write("Cantidad de litros de combustible actual: ");
            int Combustible = int.Parse(Console.ReadLine());
            int CalculoInicial = AñosLuz * 12;



            if (CalculoInicial <= Combustible)
            {
                Console.WriteLine("Cálculos precisos. Saltando al hiperespacio");

            }
            else
            {
                int Faltante = AñosLuz * 12 - Combustible;
                Console.WriteLine("Peligro: Combustible insuficiente. Faltan " + Faltante + " litros.");
            }         

        }
    }
}

