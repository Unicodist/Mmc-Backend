using System.Globalization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Dto;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;
using Mmc.Blog.ViewModel;

namespace Mechi.Backend.Controllers.Blog;

public class BlogController : Controller
{
    private readonly IBlogPostRepository _blogRepo;
    private readonly IBlogService _blogService;
    // GET
    public BlogController(IBlogPostRepository blogRepo, IBlogService blogService)
    {
        this._blogRepo = blogRepo;
        _blogService = blogService;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet("/{id}")]
    public async Task<IActionResult> Read(int id)
    {
        var blog = await _blogRepo.GetById(id)??throw new ArticleNotFoundException();
        var model = new ArticleReadViewModel()
        {
            Title = blog.Title,
            AuthorName = blog.AuthorName,
            Body = blog.Body,
            Categories = blog.Category.Name,
            Date = blog.PostedDate.ToString(CultureInfo.InvariantCulture)
        };
        return View(model);
    }

    public IActionResult Read() => RedirectToAction("Index");
    [Authorize]
    [HttpGet]
    public IActionResult Write()
    {
        return View();
    }
    [Authorize]
    public async Task<IActionResult> Write(ArticleCreateViewModel model)
    {
        var articleDto = new ArticleCreateDto()
        {
            Title = model.Title,
            AdminId = 1,
            AuthorName = "PlaceHolder",
            Body = model.CkEditorBody,
            PostedDate = DateTime.Now
        };
        await _blogService.Create(articleDto);
        return Ok();
    }
}