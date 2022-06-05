using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.ApiResponseModel.Blog;
using Mmc.Blog.Repository;

namespace Mechi.Backend.Controllers.Api;

[ApiController]
[Route("api/[controller]")]
public class BlogApiController : ControllerBase
{
    private readonly IArticleRepository _articleRepository;

    public BlogApiController(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
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
        var blogMaster = await _articleRepository.GetByIdAsync(id);
        var dto = new BlogPostResponseApiModel(blogMaster.Title, blogMaster.Body, blogMaster.AuthorAdmin.Name,
            blogMaster.PostedDate.ToString(CultureInfo.CurrentCulture));
        
        return Ok(dto);
    }
}