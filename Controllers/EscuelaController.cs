using ASP.NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            
            escuela.Nombre = "Platzi Academy";
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Ciudad = "Barranquilla";
            escuela.Pais = "Colombia";
            escuela.Dirección = "Calle 72 # 43 - 115";
            escuela.TipoEscuela = TiposEscuela.PreEscolar;

            return View(escuela);
        }
    }
}
