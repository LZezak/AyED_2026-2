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
            double CantidadMinutos;
            double Horas;
            double Minutos;
            double PrecioHoras;
            double PrecioMinutos;
            double CostoTotal;
            double IvaPorcentaje = 21;
            double Iva;
            double MontoFinal;

            Console.Write("Minutos en el espacionamiento: ");
            CantidadMinutos = Convert.ToInt32(Console.ReadLine());


            Horas = CantidadMinutos / 60;
            Minutos = CantidadMinutos % 60;
            PrecioHoras = Horas * 6000;
            PrecioMinutos = Minutos * 150;
            CostoTotal = PrecioHoras + PrecioMinutos;
            Iva = CostoTotal * IvaPorcentaje / 100;
            MontoFinal = PrecioHoras + PrecioMinutos + Iva;


            Console.WriteLine("El precio a pagar es de " + MontoFinal);


        }
    }
}
