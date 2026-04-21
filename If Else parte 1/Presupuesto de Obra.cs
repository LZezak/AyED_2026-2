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
            Console.Write("Ingrese presupuesto de la obra: ");
            int Presupuesto = int.Parse(Console.ReadLine());
            Console.Write("Ingresar costo de los materiales: ");
            int Costo = int.Parse(Console.ReadLine());

            if (Costo > Presupuesto)
            {
                int Calculo = Costo - Presupuesto;
                Console.WriteLine("Se necesitan pedir prestados " + Calculo + "$.");
            }
            

        }
    }
}