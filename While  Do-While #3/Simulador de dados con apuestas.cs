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
            int Saldo = 100;
            int Dado1;
            int Dado2;
            int Apuesta = 1;
            int Resultado;
            Console.WriteLine("CASINO");
            Console.WriteLine("Apuesta los 100 creditos que tienes. 1 credito = 1 tirada");
            Console.WriteLine("Si los dos dados forman 7 u 11 GANAS, sino pierdes");

            do
            {
                if (Saldo == 0)
                {
                    Console.WriteLine("Te quedaste sin saldo");
                    Apuesta = 0;
                }
                if (Saldo > 0)
                {
                    Console.Write("Ingrese creditos a apostar: ");
                    Apuesta = int.Parse(Console.ReadLine());
                    if (Apuesta != 0)
                    {
                    
                        if (Apuesta <= Saldo)
                        {
                            Console.Write("Ingrese que saco el dado 1: ");
                            Dado1 = int.Parse(Console.ReadLine());
                            if (Dado1 > 6)
                            {
                                do
                                {
                                    Console.Write("Número no valido, ingrese el VERDADERO valor que saco el dado 1: ");
                                    Dado1 = int.Parse(Console.ReadLine());
                                } while (Dado1 > 6);
                            }
                            Console.Write("Ingrese que saco el dado 2: ");
                            Dado2 = int.Parse(Console.ReadLine());
                            if (Dado2 > 6)
                            {
                                do
                                {
                                    Console.Write("Número no valido, ingrese el VERDADERO valor que saco el dado 2: ");
                                    Dado2 = int.Parse(Console.ReadLine());
                                } while (Dado2 > 6);
                            }
                            Resultado = Dado1 + Dado2;
                            if (Resultado == 7 || Resultado == 11)
                            {
                                Saldo = Saldo + (Apuesta * 2);
                                Console.WriteLine("Salio " + Resultado + ". GANADOR");
                            }
                            else
                            {
                                Saldo = Saldo - Apuesta;
                                Console.WriteLine("Salio " + Resultado + ". Perdiste");
                            }
                        }
                    }
                }
                
            } while (Apuesta != 0);
            Console.WriteLine("Saldo final: $" + Saldo);

        }
    }
}
