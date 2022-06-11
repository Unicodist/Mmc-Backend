using System.Globalization;
using Mechi.Backend.Helper;
using Mechi.Backend.ViewModel.Blog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.ApiResponseModel.Blog;
using Mmc.Blog.Dto;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;
using Mmc.Blog.ViewModel;

namespace Mechi.Backend.Controllers.Api;

[ApiController]
[Route("api/[controller]")]
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
    public async Task<IActionResult> Get()
    {
        var blogItems =await _articleRepository.GetAllBlogAsync();
        var result = blogItems!.Select(x =>
            new BlogPostResponseApiModel(x.Title, x.Body, x.AuthorAdmin.Name, x.PostedDate.ToString(CultureInfo.CurrentCulture)));
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var blogMaster = (await _articleRepository.GetByIdAsync(id))??throw new ArticleNotFoundException();
        var dto = new BlogPostResponseApiModel(blogMaster.Title, blogMaster.Body, blogMaster.AuthorAdmin.Name,
            blogMaster.PostedDate.ToString(CultureInfo.CurrentCulture));
        
        return Ok(dto);
    }

    
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Create(ArticleCreateViewModel model)
    {
        var user = this.GetCurrentBlogUser();
        var articleDto = new ArticleCreateDto(model.Title, model.CkEditorBody, user.Id, model.CategoryGuid);
        var article = await _blogService.Create(articleDto);
        return Ok(new ArticleViewModel()
        {
            
        });
    }
}