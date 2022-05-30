using System;
using System.Collections.Generic;

namespace ASP.NET_Core.Models
{

    public class AlumnoPromedio
    {
        public float promedio;
        public string alumnoid;
        public string alumnoNombre;

         public override string ToString()
        {
            return $"Alumno: \"{alumnoNombre}\", Promedio: {promedio}";
        }
    }
}