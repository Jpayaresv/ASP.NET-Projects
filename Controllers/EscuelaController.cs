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
            escuela.AñoFundación = 2005;
            escuela.EscuelaId = Guid.NewGuid().ToString();

            return View(escuela);
        }
    }
}
