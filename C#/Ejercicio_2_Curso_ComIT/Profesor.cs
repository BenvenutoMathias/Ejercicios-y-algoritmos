using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Curso_ComIT
{
    public class Profesor : Persona 
    {
        public int AñosExperiencia { get; set; }
        public Profesor(string nombre, string apellido, int dni, int añosExperiencia, DateTime fechaNacimiento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.AñosExperiencia = añosExperiencia;
            this.FechaNacimiento = fechaNacimiento;
        }
    }
}
