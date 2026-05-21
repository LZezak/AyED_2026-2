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
            int Saldo = 10000;
            int Eleccion;
            do
            {
                Console.WriteLine("Seleccione que desea hacer: ");
                Console.WriteLine("1. Depositar dinero");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Ver saldo actual");
                Console.WriteLine("4. Salir");
                Console.Write("Elija: ");
                Eleccion = int.Parse(Console.ReadLine());
                switch (Eleccion)
                {
                    case 1:
                        Console.Write("Cuanto dinero desea ingresar: ");
                        int DineroIngresado = int.Parse(Console.ReadLine());
                        Saldo = Saldo + DineroIngresado;
                        Console.WriteLine("$" + DineroIngresado + " ingresados con exito");
                        Console.WriteLine("Saldo actual de: $" + Saldo);
                        break;

                    case 2:
                        Console.Write("Cuanto dinero desea retirar: ");
                        int DineroRetirado = int.Parse(Console.ReadLine());
                        Saldo = Saldo - DineroRetirado;
                        Console.Write("$" + DineroRetirado + " retirados con exito");
                        Console.WriteLine("Saldo actual de: $" + Saldo);
                        break;

                    case 3:
                        Console.WriteLine("Saldo actual: $" + Saldo);
                        break;

                    case 4:
                        Eleccion = 0;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida, intente de nuevo");
                        break;
                }

            } while (Eleccion != 0) ;
            
        }
    }
}
