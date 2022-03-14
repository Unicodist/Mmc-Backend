using Mechi.Backend.Services;
using Microsoft.AspNetCore.Mvc;
using Mmc.Api.Dto;
using Mmc.Data;

namespace Mmc.Blog.Api;

[ApiController]
public class BlogApiController
{
    private BaseDbContext _context = new();
    
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
        var blogMaster = await _context.BlogMasters.FindAsync(id);
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