using Microsoft.AspNetCore.Mvc;

namespace Mmc.Api.ApiControllers;

[ApiController]
public class BlogController 
{
    [HttpGet]
    [Route("api/blog")]
    public async Task<string> Index()
    {
        return "Hello World";
    }
}