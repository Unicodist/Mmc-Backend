using System.Globalization;
using Mechi.Backend.ApiModel.Blog;
using Mechi.Backend.Helper;
using Mechi.Backend.ViewModel.Blog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Dto;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mechi.Backend.Controllers.Api;

[ApiController]
[Route("api/[controller]")]
public class BlogApiController : ControllerBase
{
    private readonly IArticleRepository _articleRepository;
    private readonly IBlogService _blogService;
    private readonly ICommentService _commentService;

    public BlogApiController(IArticleRepository articleRepository, IBlogService blogService, ICommentService commentService)
    {
        _articleRepository = articleRepository;
        _blogService = blogService;
        _commentService = commentService;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var blogItems =await _articleRepository.GetAllBlogAsync();
        var result = blogItems!.Select(x =>
            new BlogPostResponseApiModel(x.Title, x.Body, x.User.Name, x.PostedDate.ToString(CultureInfo.CurrentCulture),x.Guid,x.Thumbnail));
        return Ok(result);
    }

    [HttpGet]
    [Route("{guid}")]
    public async Task<IActionResult> Get(string guid)
    {
        try
        {
            var blogMaster = (await _articleRepository.GetByGuidAsync(guid));
            var dto = new BlogPostResponseApiModel(blogMaster.Title, blogMaster.Body, blogMaster.User.Name,
                blogMaster.PostedDate.ToString(CultureInfo.CurrentCulture),blogMaster.Guid,blogMaster.Thumbnail);
        
            return Ok(dto);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    
    [Authorize]
    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> Create([FromBody]ArticleCreateViewModel model)
    {
        var user = this.GetCurrentBlogUser();
        var filePath = await FileHandler.UploadFile(model.Thumbnail);
        
        var articleDto = new ArticleCreateDto(model.Title, model.CkEditorBody, user.Id, model.CategoryGuid,filePath);
        var article = await _blogService.Create(articleDto);
        return Ok(new ArticleViewModel
        {
            Title = article.Title,
            Body = article.Body,
            DateTime = article.PostedDate.ToDateTime(article.PostedTime),
            Guid = article.Guid,
            Image = article.Thumbnail
        });
    }
}