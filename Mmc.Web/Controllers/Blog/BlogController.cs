using System.Globalization;
using Mechi.Backend.ApiModel.Comment;
using Mechi.Backend.Helper;
using Mechi.Backend.Helper.DateHelper;
using Mechi.Backend.ViewModel;
using Mechi.Backend.ViewModel.Blog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Dto;
using Mmc.Blog.Entity;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mechi.Backend.Controllers.Blog;
public class BlogController : Controller
{
    private readonly IArticleRepository _blogRepo;
    private readonly IBlogService _blogService;
    private readonly ICommentRepository _commentRepository;
    private IWebHostEnvironment _webHostEnvironment;

    private readonly ICommentService _commentService;

    // GET
    public BlogController(IArticleRepository blogRepo, 
        IBlogService blogService,
        ICommentRepository commentRepository, 
        IBlogUserRepository userRepository, ICommentService commentService, IWebHostEnvironment webHostEnvironment)
    {
        _blogRepo = blogRepo;
        _blogService = blogService;
        _commentRepository = commentRepository;
        _commentService = commentService;
        _webHostEnvironment = webHostEnvironment;
        UserHelper.UserRepository = userRepository;
    }
    public async Task<IActionResult> Index(int? page = 1)
    {
        var articles = (await _blogRepo.GetAllBlogAsync().ConfigureAwait(false));
        if (articles != null && !articles.Any())
        {
            return View("Errors/_No_Articles");
        }
        var modelArticles = articles.Select(x => new ArticleViewModel {Guid = x.Guid, Body = x.Body, DateTime = DateHelper.GetDateTime(x.PostedDate,x.PostedTime), Image = "abc", Title = x.Title});
        var pinned = modelArticles.First();
        modelArticles.ToList().Remove(pinned);
        var model = new BlogHomeViewModel
        {
            Articles = modelArticles,
            PageCount = page??1,
            Pinned = pinned
        };
        return View(model);
    }
    [Route("[controller]/Read/{guid}")]
    public async Task<IActionResult> Read(string guid)
    {
        var blog = await _blogRepo.GetByGuidAsync(guid)??throw new ArticleNotFoundException();
        var model = new ArticleReadViewModel
        {
            Title = blog.Title,
            AuthorName = blog.User.Name,
            Body = blog.Body,
            Category = blog.Category?.Name,
            Date = blog.PostedDate.ToString(CultureInfo.InvariantCulture),
            Guid = blog.Guid.ToString(),
            LikeCount = blog.Likes.Count
        };
        if (User.Identity!.IsAuthenticated)
        {
            var user = this.GetCurrentBlogUser();
            model.Liked = blog.Likes.Select(x => x.UserId).Contains(user.Id);
        }
        return View(model);
    }
    [Authorize]
    [Route("Write")]
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
    [Route("[controller]/GetBlogPaginationView/{page}")]
    public PartialViewResult GetBlogPaginationView(int page=1)
    {
        var blogPage = _blogRepo.GetQueryable().Count()/5;
        var model = new BlogPaginationViewModel
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
        var model = new CommentSectionViewModel
        {
            Comments = comments.Take(page*10).Reverse().Select(x => new CommentItemViewModel
            {
                Body = x.Body,
                Guid = x.Guid.ToString(),
                Name = x.User.UserName,
                Picture = Path.Combine(x.User.Picture.Location),
                SelfComment = article.User.Id == x.Id
            })
        };
        return PartialView("PartialViews/Blog/CommentItem", model);
    }

    [Route("[controller]/GetCommentView")]
    [Authorize]
    public async Task<IActionResult> GetCommentView(string guid)
    {
        var comment = await _commentRepository.GetByGuidAsync(guid) ?? throw new CommentNotFoundException();
        var user = this.GetCurrentBlogUser();
        var model = new CommentItemViewModel()
        {
            Guid = comment.Guid.ToString(),
            Body = comment.Body,
            SelfComment = user.Id == comment.UserId,
            Name = user.Name,
            Picture = user.Picture.Location
        };
        return PartialView("PartialViews/Blog/SingleCommentView",model);
    }
    
    [HttpPost]
    [Route("[controller]/CreateComment")]
    [Authorize]
    public async Task<JsonResult> CreateComment(CommentCreateViewModel model)
    {
        var user = this.GetCurrentBlogUser();
        var commentDto = new CommentCreateDto(model.ArticleGuid,model.Body,user.Id);
        var comment = await _commentService.Create(commentDto);
        var commentModel = new CommentResponseApiModel
        {
            Body = comment.Body,
            Guid = comment.Guid.ToString(),
            SelfAuthor = comment.UserId == user.Id
        };
        return Json(commentModel);
    }
}
