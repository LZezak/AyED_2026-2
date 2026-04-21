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

            Console.Write("Ingresar cantidad de facturas producidas: ");
            int Facturas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresar cantidad de docenas vendidas: ");
            int Docenas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresar precio por docena: ");
            int Precio = Convert.ToInt32(Console.ReadLine());
            int FacturasSobrantes = Facturas - (Docenas * 12);
            int Ganancias = Docenas * Precio;


            Console.WriteLine("Sobraron " + FacturasSobrantes + " facturas");
            Console.WriteLine("Se recaudaron " + Ganancias + "$");
            if (FacturasSobrantes > 6)
            {
                Console.WriteLine("Alerta: Exceso de producción");
            }
            else
            {
                Console.WriteLine("Producción eficiente");
            }

            


        }
    }
}