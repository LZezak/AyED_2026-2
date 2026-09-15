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
            Console.Write("Cuantos números desea ingresar: ");
            int CantNum = int.Parse(Console.ReadLine());
            int Numero;
            int Mayor = 0;
            int SegMayor = 0;
            for (int i = CantNum; i != 0; i--)
            {
                Console.Write("Ingrese un número entero: ");
                Numero = int.Parse(Console.ReadLine());
                SegMayor = ObtenerSegundoMayor(Numero, Mayor, SegMayor);
                Mayor = ObtenerMayor(Numero, Mayor);

            }
            if (CantNum <= 2 || Mayor == SegMayor)
            {
                Console.WriteLine("No hay o no puede haber un número que pueda ser el segundo mayor");
            }
            else
            {
                Console.WriteLine("El segundo número mas grande ingresado fue: " + SegMayor);
            }
        }
        static int ObtenerMayor(int Num, int May)
        {
            if (Num > May)
            {
                return Num;
            }
            return May;
        }
        static int ObtenerSegundoMayor(int Num, int May, int SegMay)
        {
            if (Num > May)
            {
                return May;
            }
            else if (Num > SegMay && Num < May)
            {
                return Num;
            }
            return SegMay;
        }
    }
}