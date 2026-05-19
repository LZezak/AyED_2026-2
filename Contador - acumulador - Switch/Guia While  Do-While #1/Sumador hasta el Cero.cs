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
            int Alcancia = 0;
            int DineroIngresado;
            Console.WriteLine("(Al ingresar 0 se mostrara el resultado)");
            Console.WriteLine(" ");

            do
            {
                Console.Write("Ingrese dinero en la alcancía: ");
                DineroIngresado = int.Parse(Console.ReadLine());
                Alcancia = Alcancia + DineroIngresado;
            } while (DineroIngresado != 0);

            Console.WriteLine("El total en su alcancía es: " + Alcancia + "$");
        }
    }
}
