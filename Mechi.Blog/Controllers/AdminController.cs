using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.Controllers
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
