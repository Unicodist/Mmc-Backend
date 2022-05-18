using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.ApiResponseModel.Blog;
using Mmc.Core.Repository;

namespace Mmc.Blog.Api;

[ApiController]
[Route("api/[controller]")]
public class BlogController : ControllerBase
{
    private IBlogPostRepository _blogPostRepository;

    public BlogController(IBlogPostRepository blogPostRepository)
    {
        _blogPostRepository = blogPostRepository;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var blogItems =await _blogPostRepository.GetAll();
        var result = blogItems.Select(x => new BlogPostResponseApiModel()
        {
            Title = x.Title,
            Body = x.Body,
            Author = x.AuthorName,
            Date = x.PostedDate.ToString()
        });
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var blogMaster = await _blogPostRepository.GetById(id);
        var dto = new BlogPostResponseApiModel()
        {
            Title = blogMaster.Title,
            Body = blogMaster.Body,
            Author = blogMaster.AuthorName,
            Date = blogMaster.PostedDate.ToString()
        };
        return Ok(dto);
    }
}