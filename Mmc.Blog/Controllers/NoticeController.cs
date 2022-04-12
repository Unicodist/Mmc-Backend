using Microsoft.AspNetCore.Mvc;

namespace Mmc.Backend.Controllers;

public class NoticeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult List()
    {
        return View();
    }
}