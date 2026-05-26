using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroIngresado;
            int Pos = 0;
            int Neg = 0;
            int Ceros = 0;
            string Entrada = "";
            Console.WriteLine("Contador de números positivos, negativos y ceros");
            Console.WriteLine("Para salir del bucle presione X o n");
            do
            {
                Console.Write("Ingrese Número: ");
                Entrada = Console.ReadLine();

                if (Entrada != "X" && Entrada != "n")
                {
                    NumeroIngresado = int.Parse(Entrada);
                

                    if (NumeroIngresado > 0)
                    {
                        Pos++;
                    }
                    else if(NumeroIngresado < 0)
                    {
                        Neg++;
                    }
                    else
                    {
                        Ceros++;
                    }
                }
            } while (Entrada != "X" && Entrada != "n");

            Console.WriteLine("Positivos: " + Pos);
            Console.WriteLine("Negativos: " + Neg);
            Console.WriteLine("Ceros: " + Ceros);

            }
    }
}
