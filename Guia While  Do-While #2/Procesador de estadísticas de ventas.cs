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
            int TotalRecaudado = 0;
            int Venta;
            int CantidadVentas = 0;
            int VentaMasAlta = 0;
            string Eleccion;
            int Bandera = 1;
            do
            {
                Console.Write("Desea ingresar una venta (S/N): ");
                Eleccion = Console.ReadLine();
                if(Eleccion == "S")
                {
                    Console.Write("Ingrese monto de la venta: $");
                    Venta = int.Parse(Console.ReadLine());
                    TotalRecaudado = TotalRecaudado + Venta;
                    if (Venta > VentaMasAlta)
                    {
                        VentaMasAlta = Venta;
                    }
                    CantidadVentas++;
                }
                else if(Eleccion == "N")
                {
                    Console.WriteLine("La facturación total fue de $" + TotalRecaudado);
                    Console.WriteLine("La cantidad de ventas realizadas fue: " + CantidadVentas);
                    Console.WriteLine("La mejor venta fue de $" + VentaMasAlta);

                    Bandera = 0;
                }
                else
                {
                    Console.WriteLine("Es si o no capo, S o N, y en mayusculas, si es eso te la perdono.");
                }
            } while (Bandera != 0);

        }
    }
}
