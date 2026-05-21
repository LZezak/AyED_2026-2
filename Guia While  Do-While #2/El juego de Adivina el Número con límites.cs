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
            int NumSecreto = 37;
            Console.WriteLine("ADIVINE EL NÚMERO (1-100)");
            Console.WriteLine("5 INTENTOS");
            int Eleccion;
            int Bandera = 1;
            int ContadorFallos = 0;
            do
            {
                Console.Write("Cual cree que es el número: ");
                Eleccion = int.Parse(Console.ReadLine());
                if (Eleccion != NumSecreto)
                {
                    ContadorFallos++;
                    if(Eleccion < NumSecreto)
                    {
                        Console.WriteLine("El número es mas grande");
                    }
                    else
                    {
                        Console.WriteLine("El número es mas pequeño");
                    }
                }
                else
                {
                    Console.WriteLine("Felicidades, hallaste el número secreto en " + (ContadorFallos + 1) + " intento/s");
                    Bandera = 0;
                }

                if(ContadorFallos == 5)
                {
                    Console.WriteLine("Pero que pena, 5 intentos. Perdiste.");
                    Bandera = 0;
                }

            } while (Bandera != 0);

        }
    }
}
