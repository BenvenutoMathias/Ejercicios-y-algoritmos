using System.Collections.Generic;

namespace Ejercicio_2_Curso_ComIT
{
    public class Curso
    {
        public string Nombre { get; set; }
        public int CantMax { get; set; }
        public Profesor Profesor { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Curso(string nombre, int cantMax, Profesor profesor, List<Alumno> alumnos)
        {
            this.Nombre = nombre;
            this.CantMax = cantMax;
            this.Profesor = profesor;
            this.Alumnos = alumnos;
        }
    }
}
