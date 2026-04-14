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

            Console.Write("Ingresar monto a pagar: ");
            double Precio = double.Parse(Console.ReadLine());
            double Porcentaje = 15;

            if (Precio >= 5000)
            {
                double descuento = Precio * Porcentaje / 100;
                double PrecioFinal = Precio - descuento;
                Console.WriteLine("Total a pagar: " + PrecioFinal);
            }
            else 
            {
                Console.WriteLine("Total a pagar: " + Precio);
            }
            

        }
    }
}