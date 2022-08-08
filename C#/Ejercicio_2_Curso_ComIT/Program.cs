using System;
using System.Collections.Generic;
namespace Ejercicio_2_Curso_ComIT
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Alumno> alumnos = new List<Alumno>()
            {
                new Alumno("Geremias", "Fernandez", 4067871, false, Convert.ToDateTime("23/10/1997")),
                new Alumno("Mathias", "Benvenuto", 40677285, true, Convert.ToDateTime("25/12/1990")),
                new Alumno("Lucas", "Rodriguez", 3541217, true, Convert.ToDateTime("19/9/1986"))
            };
            


            Profesor Martin = new Profesor("Martin", "Comparetto", 5687458, 10, Convert.ToDateTime("10/4/1980"));

            Curso csharp = new Curso("C# .NET", 50, Martin, alumnos);


            Console.WriteLine($"{csharp.Nombre} {csharp.Profesor.Nombre} {csharp.Profesor.FechaNacimiento} {csharp.CantMax} {csharp.Alumnos.Count}");

            foreach (Alumno alumno in csharp.Alumnos)
            {
                Console.WriteLine($"{alumno.Nombre} {alumno.Apellido} {alumno.DNI} {alumno.FechaNacimiento.ToShortDateString()}");
            }

        }
    }
}
