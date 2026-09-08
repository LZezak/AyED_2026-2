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
            int Positivo = 0;
            int Negativo = 0;
            int Cero = 0;
            int PromedioPos = 0;
            int PromedioNeg = 0;
            int SumaPos = 0;
            int SumaNeg = 0;
            for (int i = CantNum; i != 0; i--)
            {
                Console.Write("Ingrese un número entero: ");
                Numero = int.Parse(Console.ReadLine());
                if (Numero > 0)
                {
                    SumaPos += Numero;
                }
                else
                {
                    SumaNeg += Numero;
                }
                Positivo = ObtenerPositivo(Numero, Positivo);
                Negativo = ObtenerNegativo(Numero, Negativo);
                Cero = ObtenerCero(Numero, Cero);
            }
            PromedioPos = ObtenerPromedioPos(SumaPos, Positivo, PromedioPos);
            PromedioNeg = ObtenerPromedioNeg(SumaNeg, Negativo, PromedioNeg);
            Console.WriteLine("Hay " + Positivo + " números positivos");
            Console.WriteLine("Hay " + Negativo + " números negativos");
            Console.WriteLine("Hay " + Cero + " números que son 0");
            Console.WriteLine("El promedio de los positivos fue: " + PromedioPos);
            Console.WriteLine("El promedio de los negativos fue: " + PromedioNeg);

        }
        static int ObtenerPositivo(int Num, int Pos)
        {
            if (Num > 0)
            {
                Pos++;
            }
            return Pos;
        }
        static int ObtenerNegativo(int Num, int Neg)
        {
            if (Num < 0)
            {
                Neg++;
            }
            return Neg;
        }
        static int ObtenerCero(int Num, int Cer)
        {
            if (Num == 0)
            {
                Cer++;
            }
            return Cer;
        }
        static int ObtenerPromedioPos(int SumaPos, int CantidadNum, int ProPos)
        {
            if (CantidadNum == 0)
            {
                CantidadNum++;
            }
            ProPos = SumaPos / CantidadNum;
            return ProPos;
        }
        static int ObtenerPromedioNeg(int SumaNeg, int CantidadNum, int ProNeg)
        {
            if (CantidadNum == 0)
            {
                CantidadNum++;
            }
            ProNeg = SumaNeg / CantidadNum;
            return ProNeg;
        }
    }
}