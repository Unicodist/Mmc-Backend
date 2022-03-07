using Microsoft.AspNetCore.Mvc;

namespace Mmc.Api.ApiControllers;

[ApiController]
public class BlogController 
{
    [HttpGet]
    public async Task<string> Index()
    {
        return "Hello World";
    }
}