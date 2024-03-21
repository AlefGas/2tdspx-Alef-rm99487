using Microsoft.AspNetCore.Mvc;

namespace Prova.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
