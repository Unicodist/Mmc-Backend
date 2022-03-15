using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.Controllers;
[Microsoft.AspNetCore.Components.Route("/write")]
public class WriteController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}