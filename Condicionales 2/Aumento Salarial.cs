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
            Console.Write("Ingrese cantidad de segundos: ");
            int Segundos = int.Parse(Console.ReadLine());
            int Minutos = Segundos / 60;
            int SegundosSinMinutos = Segundos - (Minutos * 60);

            if (Segundos > 60)
            {
                Console.WriteLine("Minutos = " + Minutos + "   —————   Segundos = " + SegundosSinMinutos);
            }
            else
            {
                Console.WriteLine("Segundos = " + Segundos);
            }



        }
    }
}