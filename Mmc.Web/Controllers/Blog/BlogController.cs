using System.Globalization;
using Mechi.Backend.ViewModel;
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
    private readonly IArticleRepository _blogRepo;
    private readonly IBlogService _blogService;
    // GET
    public BlogController(IArticleRepository blogRepo, IBlogService blogService)
    {
        this._blogRepo = blogRepo;
        _blogService = blogService;
    }
    public async Task<IActionResult> Index()
    {
        var articles = await _blogRepo.GetAllBlogAsync().ConfigureAwait(false);
        var modelArticles = articles.Select(x => new ArticleViewModel()
            {BlogId = x.Id, Body = x.Body, DateTime = x.PostedDate, Image = "abc", Title = x.Title});
        var pinned = modelArticles.First();
        var model = new BlogHomeViewModel()
        {
            Articles = modelArticles,
            PageCount = 1,
            Pinned = modelArticles.First()
        };
        return View(model);
    }
    public IActionResult Index(int page)
    {
        ViewData["PageCount"] = page;
        return View();
    }
    public async Task<IActionResult> Read(int id)
    {
        var blog = await _blogRepo.GetArticleByIdAsync(id)??throw new ArticleNotFoundException();
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
    public IActionResult Write()
    {
        return View();
    }
    [Authorize]
    [HttpPost]
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
    public async Task<IActionResult> GetDynamicPartialView(int page)
    {
        var blogPage = _blogRepo.GetBlogQueryable().Count()/5;
        var model = new BlogPaginationViewModel()
        {
            CurrentPage = page,
            TotalPageCount = blogPage,
            FirstPage = page==1,
            LastPage = page==blogPage
        };
        return PartialView("_Partial_Blog_Pagination",model);
    }
}