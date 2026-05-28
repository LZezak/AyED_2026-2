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
            string RespuestaPresentismo;
            string RespuestaSeguir;
            string Alumno;
            float CantAlumnos = 0;
            float Presentes = 0;
            int Ausentes = 0;
            float PorcentajeAsistencia;
            Console.WriteLine("Listado");
            do
            {
                Console.Write("Ingrese nombre del alumno: ");
                Alumno = Console.ReadLine();
                CantAlumnos++;
                Console.Write("Esta presente (P/A): ");
                RespuestaPresentismo = Console.ReadLine();
                if (RespuestaPresentismo == "P")
                {
                    Presentes++;
                }
                else if (RespuestaPresentismo == "A")
                {
                    Ausentes++;
                }
                else
                {
                    Console.WriteLine("Respuesta no valida (quiza no esta en mayuscula)");
                }
                Console.Write("Desea ingrear mas alumnos (S/N): ");
                RespuestaSeguir = Console.ReadLine();
                if (RespuestaSeguir == "N")
                {
                    Bandera = 0;
                }
            } while (Bandera != 0);
            PorcentajeAsistencia = Presentes / CantAlumnos * 100;
            Console.WriteLine("Alumnos presentes: " + Presentes);
            Console.WriteLine("Alumnos ausentes: " + Ausentes);
            Console.WriteLine("Porcentaje de asistencia: " + PorcentajeAsistencia + "%");

        }
    }
}
