using Microsoft.AspNetCore.Mvc;

namespace Mmc.Backend.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
