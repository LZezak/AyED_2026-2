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
            int Bandera = 1;
            int i = 1; 
            int NumeroMasChico = 99999999;
            int Respuesta;
            Console.WriteLine("Ingrese números enteros positivos: ");
            Console.WriteLine("(Ingese un número negativo para salir)");

            do
            {
                Console.Write("Ingrese número " + i + ": ");
                Respuesta = int.Parse(Console.ReadLine());
                if(Respuesta < NumeroMasChico && Respuesta >= 0)
                {
                    NumeroMasChico = Respuesta;
                }
                i++;
                if (Respuesta < 0)
                {
                    Bandera = 0;
                }
            } while (Bandera != 0);
            Console.WriteLine("El número mas chico es " + NumeroMasChico);

        }
    }
}
