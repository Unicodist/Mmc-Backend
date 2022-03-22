using Microsoft.AspNetCore.Mvc;
using Mmc.Api.Dto;
using Mmc.Core.Repository;

namespace Mmc.Blog.Api;

[ApiController]
[Route("api/[controller]")]
public class BlogController : ControllerBase
{
    private BlogPostRepositoryInterface _blogPostRepository;

    public BlogController(BlogPostRepositoryInterface blogPostRepository)
    {
        _blogPostRepository = blogPostRepository;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var blogItems =await _blogPostRepository.GetAll();
        var result = blogItems.Select(x => new BlogMasterResponseApiModel()
        {
            Title = x.BlogMasterTitle,
            Body = x.BlogMasterBody,
            Author = x.BlogMasterAuthorName,
            Date = x.BlogMasterPostedDate.ToString()
        });
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var blogMaster = await _blogPostRepository.GetById(id);
        BlogMasterResponseApiModel dto = new BlogMasterResponseApiModel()
        {
            Title = blogMaster.BlogMasterTitle,
            Body = blogMaster.BlogMasterBody,
            Author = blogMaster.BlogMasterAuthorName,
            Date = blogMaster.BlogMasterPostedDate.ToString()
        };
        return Ok(dto);
    }
}