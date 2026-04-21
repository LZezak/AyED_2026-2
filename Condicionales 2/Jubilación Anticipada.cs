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
            Console.Write("Ingrese su sueldo: ");
            float Sueldo = float.Parse(Console.ReadLine());
            Console.Write("Ingrese sus años de antigüedad: ");
            float Antigüedad = float.Parse(Console.ReadLine());
            float Aumento10 = (Sueldo * 20) / 100;
            float AumentoMenosDe10 = (Sueldo * 5) / 100;
            float SueldoNuevo10 = Sueldo + Aumento10;
            float SueldoNuevoMenosDe10 = Sueldo + AumentoMenosDe10;


            if (Antigüedad > 10)
            {
                Console.WriteLine("Nuevo sueldo = " + SueldoNuevo10 + "$");
            }
            else
            {
                Console.WriteLine("Nuevo sueldo = " + SueldoNuevoMenosDe10 + "$");
            }



        }
    }
}