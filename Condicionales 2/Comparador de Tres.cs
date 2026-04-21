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

            Console.Write("Horas en el espacionamiento: ");
            int Horas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dinero con el que va a pagar: ");
            int Dinero = Convert.ToInt32(Console.ReadLine());
            int Precio1 = 4000;
            int Precio2 = 4000 + ((Horas - 1) * 1600);

            if (Horas <= 1)
            {
                if(Dinero >= Precio1)
                {
                    Console.WriteLine("Monto a pagar: " + Precio1 + "$");
                    Console.WriteLine("Vuelto: " + (Dinero - Precio1) + "$");
                }
                else
                {
                    Console.WriteLine("Faltan: " + Precio1 + "$");

                }

            }
            else
            {
                if (Dinero >= Precio2)
                {
                    Console.WriteLine("Monto a pagar: " + Precio2 + "$");
                    Console.WriteLine("Vuelto: " + (Dinero - Precio2) + "$");
                }
                else
                {
                    Console.WriteLine("Faltan: " + Precio2 + "$");

                }
            }


        }
    }
}