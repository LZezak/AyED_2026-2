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
            Console.Write("Ingrese su genero (F/M): ");
            String Genero = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            int Edad = int.Parse(Console.ReadLine());

            if (Genero == "F")
            {
                if(Edad >= 60)
                Console.WriteLine("Puede iniciar el trámite jubilatorio");
            }
            if (Genero == "M")
            {
                if (Edad >= 65)
                    Console.WriteLine("Puede iniciar el trámite jubilatorio");
            }



        }
    }
}