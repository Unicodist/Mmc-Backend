using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.Controllers.Core;

public class DocumentationController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CommentError()
    {
        return Content("Not implemented");
    }
}