using System;

namespace ASP.NET_Core.Models
{
    public class Evaluación:ObjetoEscuelaBase
    {
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura  { get; set; }

        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Alumno.Nombre}, {Asignatura.Nombre}, {Nota}";
        }
    }
}