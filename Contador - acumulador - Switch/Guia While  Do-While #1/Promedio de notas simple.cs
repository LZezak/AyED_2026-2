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
            float Nota;
            int Limite = 1;
            float NotasTotal = 0;
            do
            {
                Console.Write("Ingrese nota " + Limite + ": ");
                Nota = int.Parse(Console.ReadLine());
                NotasTotal = NotasTotal + Nota;
                Limite++;
            } while (Limite <= 5);
            float CalculoPromedio = NotasTotal / 5;
            Console.WriteLine("Total Notas = " + NotasTotal);
            Console.WriteLine("Cantidad de Notas ingresadas = 5");
            Console.WriteLine(NotasTotal + " : 5 = " + CalculoPromedio);
            Console.WriteLine("Promedio Total = " + CalculoPromedio);



        }
    }
}
