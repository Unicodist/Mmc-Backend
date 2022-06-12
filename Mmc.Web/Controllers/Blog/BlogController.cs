using System.Globalization;
using Mechi.Backend.Helper;
using Mechi.Backend.ViewModel;
using Mechi.Backend.ViewModel.Blog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;
using Mmc.User.Repository;

namespace Mechi.Backend.Controllers.Blog;
public class BlogController : Controller
{
    private readonly IArticleRepository _blogRepo;
    private readonly IBlogService _blogService;
    private readonly IBlogUserRepository _userRepository;
    private readonly IUserUserRepository _userUserRepository;
    private readonly ICommentRepository _commentRepository;
    // GET
    public BlogController(IArticleRepository blogRepo, 
        IBlogService blogService, 
        IBlogUserRepository userRepository,
        ICommentRepository commentRepository, 
        IUserUserRepository userUserRepository)
    {
        _blogRepo = blogRepo;
        _blogService = blogService;
        _userRepository = userRepository;
        _commentRepository = commentRepository;
        _userUserRepository = userUserRepository;
        UserHelper.UserRepository = userUserRepository;
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
            {Guid = x.Guid, Body = x.Body, DateTime = x.PostedDate, Image = "abc", Title = x.Title});
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
    public Task<IActionResult> Index()
    {
        return Index(1);
    }
    [Route("[controller]/Read/{id}")]
    public async Task<IActionResult> Read(long id)
    {
        var blog = await _blogRepo.GetByIdAsync(id)??throw new ArticleNotFoundException();
        var model = new ArticleReadViewModel()
        {
            Title = blog.Title,
            AuthorName = blog.AuthorAdmin.Name,
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
    [Route("[controller]/GetDynamicPartialView/{page}")]
    public async Task<IActionResult> GetDynamicPartialView(int page=1)
    {
        var blogPage = _blogRepo.GetQueryable().Count()/5;
        var model = new BlogPaginationViewModel()
        {
            CurrentPage = page,
            TotalPageCount = blogPage,
            FirstPage = page==1,
            LastPage = page==blogPage
        };
        return PartialView("_Partial_Blog_Pagination",model);
    }

    [Route("[controller]/GetCommnets")]
    public async Task<IActionResult> GetComments(long articleId, int page)
    {
        var article = await _blogRepo.GetByIdAsync(articleId);
        var comments = await _commentRepository.GetByArticleIdAsync(articleId);
        var model = new CommentSectionViewModel()
        {
            Comments = comments.Take(page).Select(x => new CommentItemViewModel()
            {
                Body = x.Body, Guid = x.Guid.ToString(), Name = x.User.UserName, picture = x.User.picture,
                SelfComment = article.AuthorAdmin.Id == x.Id
            }),
        };
        return PartialView("PartialViews/Blog/CommentItem", model);
    }
    [Authorize]
    [Route("[controller]/Setup")]
    public IActionResult Setup()
    {
        return View();
    }
}