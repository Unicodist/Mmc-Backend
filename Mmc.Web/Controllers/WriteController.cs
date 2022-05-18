using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.ViewModel;
using Mmc.Core.Dto;
using Mmc.Core.Services;
using Mmc.Core.Services.Interface;

namespace Mmc.Backend.Controllers;
[Microsoft.AspNetCore.Components.Route("/write")]
public class WriteController : Controller
{
    private readonly BlogServiceInterface _blogService;

    public WriteController(BlogServiceInterface blogServiceInterface)
    {
        _blogService = blogServiceInterface;
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public Task Create(BlogWriteFormViewModel model)
    {
        var blogCreateDto = new BlogCreateDto()
        {
            AuthorName = "Ashish Neupane",
            AdminId = 1,
            Body = model.BlogMasterBody,
            PostedDate = DateTime.Now,
            Title = model.BlogMasterTitle
        };
        _blogService.Create(blogCreateDto);
        return Task.CompletedTask;
    }
}