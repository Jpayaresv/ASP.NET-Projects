using ASP.NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.Controllers
{
    public class AsignaturaController : Controller
    {

        public IActionResult Index(){

            var asignatura = new Asignatura{Nombre="Programación",
                                UniqueId= Guid.NewGuid().ToString()
                            };  

            return View(asignatura);
        }
        public IActionResult MultiAsignatura()
        {

            var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas",
                                UniqueId= Guid.NewGuid().ToString()
                            } ,
                            new Asignatura{Nombre="Educación Física",
                                UniqueId= Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Castellano",
                                UniqueId= Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Ciencias Naturales",
                                UniqueId= Guid.NewGuid().ToString()
                            }
                            ,
                            new Asignatura{Nombre="Programación",
                                UniqueId= Guid.NewGuid().ToString()
                            }
                };
        
            return View("MultiAsignatura",listaAsignaturas);
        }
    }
}