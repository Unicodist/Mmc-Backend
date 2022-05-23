using System.Globalization;
using Mechi.Backend.Helper;
using Mechi.Backend.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Dto;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;
using Mmc.Blog.ViewModel;

namespace Mechi.Backend.Controllers.Blog;
[Route("[controller]")]
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
    [Route("{page}")]
    public async Task<IActionResult> Index(int? page)
    {
        var articles = await _blogRepo.GetAllBlogAsync().ConfigureAwait(false);
        var modelArticles = articles.Select(x => new ArticleViewModel()
            {BlogId = x.Id, Body = x.Body, DateTime = x.PostedDate, Image = "abc", Title = x.Title});
        var pinned = modelArticles.First();
        var model = new BlogHomeViewModel()
        {
            Articles = modelArticles,
            PageCount = page??1,
            Pinned = modelArticles.First()
        };
        return View(model);
    }
    [Route("")]
    public IActionResult Index()
    {
        return RedirectToAction("Index", new {page = 1});
    }
    [Route("/Read/{id}")]
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
    [Route("Read")]
    public IActionResult Read() => RedirectToAction("Index");
    [Authorize]
    [Route("Write")]
    public IActionResult Write()
    {
        return View();
    }
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Create(ArticleCreateViewModel model)
    {
        var user = await this.GetCurrentUser();
        var articleDto = new ArticleCreateDto()
        {
            Title = model.Title,
            AdminId = user.Id,
            AuthorName = "PlaceHolder",
            Body = model.CkEditorBody,
            PostedDate = DateTime.Now
        };
        await _blogService.Create(articleDto);
        return Ok();
    }
    [Route("GetDynamicPartialView/{page}")]
    public async Task<IActionResult> GetDynamicPartialView(int page=1)
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