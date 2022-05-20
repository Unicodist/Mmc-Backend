using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.Controllers;

public class BlogController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}