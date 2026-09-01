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
            Console.Write("Ingrese el la base: ");
            int Base = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el la base (mayor o igual a 0): ");
            int Exponente = int.Parse(Console.ReadLine());
            if (Exponente < 0)
            {
                while (Exponente < 0)
                {
                    Console.Write("El numero ingresado es menor a 0, intente de nuevo: ");
                    Exponente = int.Parse(Console.ReadLine());
                }
            }
            Potencia(Base, Exponente);
        }
        static void Potencia(int Bas, int Expo)
        {
            int ExpoMen = Expo;
            int Total = Bas * Bas;
            Expo = Expo - 2;
            while (Expo != 0)
            {
                Total = Total * Bas;
                Expo--;
            }
            Console.WriteLine("El la potencia de " + Bas + " elevado a " + ExpoMen + " es: " + Total);
        }
    }
}