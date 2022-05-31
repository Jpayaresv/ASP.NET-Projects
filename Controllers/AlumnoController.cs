using ASP.NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.Controllers
{
    public class AlumnoController : Controller
    {

        public IActionResult Index(){

            var alumno = new Alumno{Nombre="Jose Payares",
                                UniqueId= Guid.NewGuid().ToString()
                            };  

            return View(alumno);
        }
        public IActionResult MultiAlumno()
        {

            var listaAlumnos = new List<Alumno>(){
                            new Alumno{Nombre="Matemáticas",
                                UniqueId= Guid.NewGuid().ToString()
                            } ,
                            new Alumno{Nombre="Educación Física",
                                UniqueId= Guid.NewGuid().ToString()
                            },
                            new Alumno{Nombre="Castellano",
                                UniqueId= Guid.NewGuid().ToString()
                            },
                            new Alumno{Nombre="Ciencias Naturales",
                                UniqueId= Guid.NewGuid().ToString()
                            }
                            ,
                            new Alumno{Nombre="Programación",
                                UniqueId= Guid.NewGuid().ToString()
                            }
                };
        
            return View("MultiAlumno",listaAlumnos);
        }
    }
}