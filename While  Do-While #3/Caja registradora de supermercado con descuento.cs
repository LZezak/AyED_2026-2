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
            int Bandera = 1;
            int i = 1;
            int Producto;
            Double PrecioTotal = 0;
            Console.WriteLine("Caja del supermercado");
            Console.WriteLine("Ingrese el precio de sus productos, pro favor escriba 0 para finalizar");
            do
            {
                Console.Write("Ingrese producto " + i + ": ");
                Producto = int.Parse(Console.ReadLine());
                PrecioTotal = PrecioTotal + Producto;
                i++;
                if (Producto == 0)
                {
                    Bandera = 0;
                }
            } while (Bandera != 0);
            if(PrecioTotal > 15000)
            {
                Double Descuento = (PrecioTotal * 10) / 100;
                PrecioTotal = PrecioTotal - Descuento;
                Console.WriteLine("Al superar los $15000 en productos tiene un descuento del 10%, $" + Descuento);
            }
            Console.WriteLine("El monto total a pagar es $" + PrecioTotal);

        }
    }
}
