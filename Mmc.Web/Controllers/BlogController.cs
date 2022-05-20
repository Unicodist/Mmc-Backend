using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.Controllers;

public class BlogController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Read()
    {
        return View();
    }
    [Authorize]
    public IActionResult Write()
    {
        return View();
    }
}