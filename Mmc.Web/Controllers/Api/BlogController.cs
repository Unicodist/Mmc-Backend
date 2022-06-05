using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.ApiResponseModel.Blog;
using Mmc.Blog.Repository;

namespace Mmc.Web.Api;

[ApiController]
[Route("api/[controller]")]
public class BlogController : ControllerBase
{
    private IArticleRepository _articleRepository;

    public BlogController(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var blogItems =await _articleRepository.GetAllBlogAsync();
        var result = blogItems.Select(x =>
            new BlogPostResponseApiModel(x.Title, x.Body, x.AuthorName, x.PostedDate.ToString(CultureInfo.CurrentCulture)));
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var blogMaster = await _articleRepository.GetByIdAsync(id);
        var dto = new BlogPostResponseApiModel(blogMaster.Title, blogMaster.Body, blogMaster.AuthorName,
            blogMaster.PostedDate.ToString(CultureInfo.CurrentCulture));
        
        return Ok(dto);
    }
}