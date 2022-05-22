using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.Controllers.Notice;

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