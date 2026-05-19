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
            Console.Write("Ingrese la clave: ");
            int Intento = int.Parse(Console.ReadLine());
            int Clave = 23451;
            do
            {
                if (Intento != Clave)
                {
                    Console.WriteLine("Clave inocrrecta");
                    Console.Write("Ingrese la clave de nuevo: ");
                    Intento = int.Parse(Console.ReadLine());
                }
            } while (Intento != Clave);
            Console.WriteLine("Clave correcta");
            Console.WriteLine("Acceso Concedido");

        }
    }
}
