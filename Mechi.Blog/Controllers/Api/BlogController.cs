using Mechi.Backend.Services;
using Microsoft.AspNetCore.Mvc;
using Mmc.Core.Entity;
using Mmc.Data;

namespace Mmc.Blog.Api;

[ApiController]
public class BlogController
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
    public async Task<BlogMaster?> Get(int id)
    {
        return await _context.BlogMasters.FindAsync(id);
    }
}