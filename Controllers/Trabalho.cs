using Microsoft.AspNetCore.Mvc;

namespace Prova.Controllers
{
    public class Trabalho : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
