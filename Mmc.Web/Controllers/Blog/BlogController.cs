using System.Globalization;
using System.Security.Claims;
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
public class BlogController : Controller
{
    private readonly IArticleRepository _blogRepo;
    private readonly IBlogService _blogService;

    private IBlogUserRepository _userRepository;
    // GET
    public BlogController(IArticleRepository blogRepo, IBlogService blogService, IBlogUserRepository userRepository)
    {
        this._blogRepo = blogRepo;
        _blogService = blogService;
        _userRepository = userRepository;
    }
    [Route("[controller]/{page}")]
    public async Task<IActionResult> Index(int? page)
    {
        var articles = await _blogRepo.GetAllBlogAsync().ConfigureAwait(false);
        if (!articles.Any())
        {
            return View("Errors/_No_Articles");
        }
        var modelArticles = articles.Select(x => new ArticleViewModel()
            {BlogId = x.Id, Body = x.Body, DateTime = x.PostedDate, Image = "abc", Title = x.Title});
        var pinned = modelArticles.First();
        modelArticles.ToList().Remove(pinned);
        var model = new BlogHomeViewModel()
        {
            Articles = modelArticles,
            PageCount = page??1,
            Pinned = pinned
        };
        return View(model);
    }
    [Route("[controller]")]
    public IActionResult Index()
    {
        return RedirectToAction("Index", new {page = 1});
    }
    [Route("[controller]/Read/{id}")]
    public async Task<IActionResult> Read(long id)
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
    [Route("[controller]/Read")]
    public IActionResult Read() => RedirectToAction("Index");
    [Authorize]
    [Route("[controller]/Write")]
    public IActionResult Write()
    {
        return View();
    }
    [Authorize]
    [HttpPost]
    [Route("[controller]/Create")]
    public async Task<IActionResult> Create(ArticleCreateViewModel model)
    {
        var userName = User.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.NameIdentifier));
        var user = _userRepository.GetByUsername(userName.Value);
        var articleDto = new ArticleCreateDto()
        {
            Title = model.Title,
            AdminId = user.Id,
            AuthorName = model.Author??user.Name,
            Body = model.CkEditorBody,
            PostedDate = DateTime.Now,
            CategoryId = 1
        };
        var article = await _blogService.Create(articleDto);
        return RedirectToAction("Read", "Blog", new {id = article.Id});
    }
    [Route("[controller]/GetDynamicPartialView/{page}")]
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