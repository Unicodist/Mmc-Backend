using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
