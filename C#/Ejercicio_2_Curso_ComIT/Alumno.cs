using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Curso_ComIT
{
    public class Alumno : Persona
    {
        public bool TieneTrabajo { get; set; }
        public Alumno(string nombre, string apellido, int dni, bool tieneTrabajo, DateTime fechaNacimiento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.TieneTrabajo = tieneTrabajo;
            this.FechaNacimiento = fechaNacimiento;
        }
    }
}
