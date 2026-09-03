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
            int Menor = 999999999;
            int Total = 0;
            int Promedio = 0;
            int Pares = 0;
            int Impares = 0;
            for (int i = CantNum; i != 0; i--)
            {
                Console.Write("Ingrese un número entero: ");
                Numero = int.Parse(Console.ReadLine());
                Mayor = ObtenerMayor(Numero, Mayor);
                Menor = ObtenerMenor(Numero, Menor);
                Total = Total + Numero;
                Promedio = ObtenerPromedio(Total, CantNum, Promedio);
                Pares = ObtenerPares(Numero, Pares);
                Impares = ObtenerImpares(Numero, Impares);
            }
            Console.WriteLine("El mayor número fue: " + Mayor);
            Console.WriteLine("El menor número fue: " + Menor);
            Console.WriteLine("El promedio fue: " + Promedio);
            Console.WriteLine("La cantidad de números pares fue: " + Pares);
            Console.WriteLine("La cantidad de números impares fue: " + Impares);

        }
        static int ObtenerMayor(int Num, int May)
        {
            if (Num > May)
            {
                return Num;
            }
            return May;
        }
        static int ObtenerMenor(int Num, int Men)
        {
            if (Num < Men)
            {
                return Num;
            }
            return Men;
        }
        static int ObtenerPromedio(int Tot, int CanNum, int Prom)
        {
            Prom = Tot / CanNum;
            return Prom; 
        }
        static int ObtenerPares(int Num, int Par)
        {
            if ((Num % 2) == 0)
            {
                Par++;
            }
            return Par;
        }
        static int ObtenerImpares(int Num, int Impar)
        {
            if ((Num % 2) != 0)
            {
                Impar++;
            }
            return Impar;
        }
    }
}