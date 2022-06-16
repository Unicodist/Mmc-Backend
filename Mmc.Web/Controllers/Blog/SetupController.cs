using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.Controllers.Blog;

public class SetupController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}