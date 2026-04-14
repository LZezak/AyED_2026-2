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


            Console.Write("M’ai t’mnee vhey, iyay dee ksh ksh droida goom? (Bienvenido viajero, ¿cuántos droides vas a comprar?): ");
            int DroidesComprados = int.Parse(Console.ReadLine());
            int PrecioDroides = 2000;



            if (DroidesComprados >= 3)
            {
                int Descuento = ((PrecioDroides * DroidesComprados) * 20) / 100;
                int PrecioFinalDescuento = (PrecioDroides * DroidesComprados) - Descuento;
                Console.WriteLine("Tadi gha droida, ibi! B’uk bee-ee m’on, m’m m’m bee chaba-chaba. (Más de 3 droides, ¡excelente! Tiene un 20% de descuento, le saldrán " + PrecioFinalDescuento + " créditos.)");

            }
            else
            {
                int PrecioFinal = PrecioDroides * DroidesComprados;
                Console.WriteLine("Nyee m’m m’m bee chaba-chaba. (Esto serán " + PrecioFinal + " créditos.)");
            }         

        }
    }
}

