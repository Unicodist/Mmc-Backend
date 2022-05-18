using Microsoft.AspNetCore.Mvc;

namespace Mmc.Backend
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
