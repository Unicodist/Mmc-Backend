using System.Globalization;
using Mechi.Backend.Helper;
using Mechi.Backend.Helper.DateHelper;
using Mechi.Backend.ViewModel;
using Mechi.Backend.ViewModel.Blog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Dto;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;
using Mmc.User.Repository;

namespace Mechi.Backend.Controllers.Blog;
public class BlogController : Controller
{
    private readonly IArticleRepository _blogRepo;
    private readonly IBlogService _blogService;
    private readonly ICommentRepository _commentRepository;
    // GET
    public BlogController(IArticleRepository blogRepo, 
        IBlogService blogService,
        ICommentRepository commentRepository, 
        IUserUserRepository userUserRepository)
    {
        _blogRepo = blogRepo;
        _blogService = blogService;
        _commentRepository = commentRepository;
        UserHelper.UserRepository = userUserRepository;
    }
    [Route("[controller]/{page}")]
    public async Task<IActionResult> Index(int? page)
    {
        var articles = await _blogRepo.GetAllBlogAsync().ConfigureAwait(false);
        if (articles != null && !articles.Any())
        {
            return View("Errors/_No_Articles");
        }
        var modelArticles = articles.Select(x => new ArticleViewModel()
            {Guid = x.Guid, Body = x.Body, DateTime = DateHelper.GetDateTime(x.PostedDate,x.PostedTime), Image = "abc", Title = x.Title});
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
    public Task<IActionResult> Index()
    {
        return Index(1);
    }
    [Route("[controller]/Read/{guid}")]
    public async Task<IActionResult> Read(string guid)
    {
        var blog = await _blogRepo.GetByGuidAsync(guid)??throw new ArticleNotFoundException();
        var model = new ArticleReadViewModel()
        {
            Title = blog.Title,
            AuthorName = blog.User.Name,
            Body = blog.Body,
            Categories = blog.Category?.Name,
            Date = blog.PostedDate.ToString(CultureInfo.InvariantCulture)
        };
        return View(model);
    }
    [Authorize]
    [Route("[controller]/Write")]
    public IActionResult Write()
    {
        return View();
    }
    public async Task<IActionResult> Create([FromForm]ArticleCreateViewModel model)
    {
        var user = this.GetCurrentBlogUser();
        var filePath = await FileHandler.UploadFile(model.Thumbnail);
        
        var articleDto = new ArticleCreateDto(model.Title, model.CkEditorBody, user.Id, model.CategoryGuid,filePath);
        _ = await _blogService.Create(articleDto);
        return Ok("Article published successfully");
    }
    [Route("GetBlogPaginationView/{page}")]
    public PartialViewResult GetBlogPaginationView(int page=1)
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
    public async Task<IActionResult> GetComments(string guid, int page)
    {
        var article = await _blogRepo.GetByGuidAsync(guid);
        var comments = await _commentRepository.GetByArticleIdAsync(article.Id);
        var model = new CommentSectionViewModel()
        {
            Comments = comments.Take(page).Select(x => new CommentItemViewModel()
            {
                Body = x.Body,
                Guid = x.Guid.ToString(),
                Name = x.User.UserName,
                picture = x.User.picture??Path.Combine(Directory.GetCurrentDirectory(), "/Images/","default.jpg"),
                SelfComment = article.User.Id == x.Id
            })
        };
        return PartialView("PartialViews/Blog/CommentItem", model);
    }
}