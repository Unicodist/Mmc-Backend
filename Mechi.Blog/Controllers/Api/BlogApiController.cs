using Microsoft.AspNetCore.Mvc;
using Mmc.Api.Dto;
using Mmc.Core.Repository;
using Mmc.Data;

namespace Mmc.Blog.Api;

[ApiController]
[Route("api/[controller]")]
public class BlogApiController
{
    private BlogPostRepositoryInterface _blogPostRepository;
    
    [HttpGet]
    [Route("api/blog")]
    public async Task<string> Get()
    {
        return "Hello world";
    }

    [HttpGet]
    [Route("api/blog{id}")]
    public async Task<BlogMasterListResponseApiModel?> Get(int id)
    {
        var blogMaster = await _blogPostRepository.GetById(id);
        BlogMasterListResponseApiModel dto = new BlogMasterListResponseApiModel()
        {
            Title = blogMaster.BlogMasterTitle,
            Body = blogMaster.BlogMasterBody,
            Author = blogMaster.BlogMasterAuthorName,
            Date = blogMaster.BlogMasterPostedDate.ToString()
        };
        return dto;
    }
}