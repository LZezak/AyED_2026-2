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
            float Peso;
            float X;

            Console.Write("Ingresar carga de la nave: ");
            Peso = Convert.ToInt32(Console.ReadLine());
            X = Peso - 5000;

            if(Peso <= 5000)
                {
                Console.WriteLine("Despegue autorizado. Buen viaje, Mando");

            }
            else
            {
                Console.WriteLine("Alerta: Exceso de peso. Debes descargar " + X + "kg para despegar");
            }


        }
    }
}
