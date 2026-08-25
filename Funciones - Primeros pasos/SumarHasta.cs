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
            int Numero;
            Console.Write("Ingrese el número hasta sumar: ");
            Numero = int.Parse(Console.ReadLine());
            SumarHasta(Numero);
        }
        static void SumarHasta(int Num)
        {
            int Total = 0;
            Total = Num + (Num - 1);
            Num--;
            while (Num != 0)
            {
                Total = Total + (Num - 1);
                Num--;
            }
            Console.WriteLine("El resultado de la suma de todos es: " + Total);
        }
    }
}