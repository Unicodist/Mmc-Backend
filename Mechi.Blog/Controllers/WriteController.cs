using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.ViewModel;
using Mmc.Data;

namespace Mmc.Backend.Controllers;
[Microsoft.AspNetCore.Components.Route("/write")]
public class WriteController : Controller
{
    // GET
    [Authorize]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public Task Create(BlogWriteFormViewModel model)
    {
        return Task.CompletedTask;
    }
}