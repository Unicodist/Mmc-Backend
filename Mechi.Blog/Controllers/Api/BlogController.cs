using Microsoft.AspNetCore.Mvc;
using Mmc.Core.Entity;
using Mmc.Data;

namespace Mmc.Blog.Api;

[ApiController]
public class BlogController
{
    private BaseDbContext _context = new();
    
    [HttpGet]
    [Route("api/blog/getall")]
    public async Task<string> GetAll()
    {
        return "Hello World";
    }

    [HttpGet]
    [Route("api/blog/get{id}")]
    public async Task<BlogMaster> Get(int id)
    {
        return await _context.BlogMasters.FindAsync(id);
    }
}