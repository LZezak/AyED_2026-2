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
            float CantGente = 0;
            float Mas18 = 0;
            int Menos18 = 0;
            int AcumuladorEdad = 0;
            int Respuesta;
            float PromedioEdad;
            Console.WriteLine("CENSO");
            Console.WriteLine("(Ingese edad negativa para salir)");

            do
            {
                Console.Write("Ingrese edad: ");
                Respuesta = int.Parse(Console.ReadLine());
                AcumuladorEdad = AcumuladorEdad + Respuesta;
                CantGente++;
                if (Respuesta < 18 && Respuesta >= 0)
                {
                    Menos18++;
                }
                else if (Respuesta > 18)
                {
                    Mas18++;
                }
                if (Respuesta < 0)
                {
                    Bandera = 0;
                }
            } while (Bandera != 0);
            PromedioEdad = AcumuladorEdad / CantGente;
            Console.WriteLine("Promedio edad: " + PromedioEdad);
            Console.WriteLine("Mayores de edad: " + Mas18);
            Console.WriteLine("Menores de edad: " + Menos18);

        }
    }
}
