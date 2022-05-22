using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.Controllers.Core
{
    public class DashboardController : Controller
    {
        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
