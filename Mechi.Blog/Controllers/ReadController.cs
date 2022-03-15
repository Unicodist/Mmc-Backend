using Mechi.Blog.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.Controllers
{
    public class ReadController : Controller
    {
        public IActionResult Index(long id)
        {
            ReadModel dto = new()
            {
                Title = "Mmc Does something",
                Body = "This Month, Mmc did something",
                Author = "Pratibha Dahal",
                PostedOn = DateTime.Now,
                viewCount = 123,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Earth_surface_NGDC_2000.jpg/800px-Earth_surface_NGDC_2000.jpg",
                ImageAlt = "HEHE",
                Tags = new List<string>(){"Technology","Casual","Sport"}
            };
            ViewData["blogInfo"] = dto;
            return View();
        }
    }
}
