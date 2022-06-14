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
[Route("api/blog/")]
public class BlogApiController : ControllerBase
{
    private readonly IArticleRepository _articleRepository;
    private readonly IBlogService _blogService;

    public BlogApiController(IArticleRepository articleRepository, IBlogService blogService)
    {
        _articleRepository = articleRepository;
        _blogService = blogService;
    }
    [HttpGet]
    [Route("get")]
    public async Task<IActionResult> Get()
    {
        var blogItems =await _articleRepository.GetAllBlogAsync();
        var result = blogItems!.Select(x =>
            new BlogPostResponseApiModel(x.Title, x.Body, x.AuthorAdmin.Name, x.PostedDate.ToString(CultureInfo.CurrentCulture),x.Guid,x.Thumbnail));
        return Ok(result);
    }

    [HttpGet]
    [Route("get/{guid}")]
    public async Task<IActionResult> Get(string guid)
    {
        try
        {
            var blogMaster = (await _articleRepository.GetByGuidAsync(guid));
            var dto = new BlogPostResponseApiModel(blogMaster.Title, blogMaster.Body, blogMaster.AuthorAdmin.Name,
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
    public async Task<IActionResult> Create([FromBody]ArticleCreateViewModel model,IFormFile thumbnail)
    {
        var user = this.GetCurrentBlogUser();
        var filePath = await FileHandler.UploadFile(thumbnail);
        
        var articleDto = new ArticleCreateDto(model.Title, model.CkEditorBody, user.Id, model.CategoryGuid,filePath);
        var article = await _blogService.Create(articleDto);
        return Ok(new ArticleViewModel()
        {
            Title = article.Title,
            Body = article.Body,
            DateTime = article.PostedDate,
            Guid = article.Guid,
            Image = article.Thumbnail
        });
    }
}