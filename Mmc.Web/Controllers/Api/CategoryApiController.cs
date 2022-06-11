using Mechi.Backend.ApiModel.Category;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Repository;

namespace Mechi.Backend.Controllers.Api;
[ApiController]
[Route("api/[controller]")]
public class CategoryApiController : ControllerBase
{
    private ICategoryRepository _categoryRepository;

    public CategoryApiController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetCategoryList()
    {
        var categories = await _categoryRepository.GetAllAsync();
        var model = categories.Select(x => new CategoryResponseModel()
        {
            Guid = x.Guid.ToString(),
            Name = x.Name,
            Description = x.Description
        });
        return Ok(model);
    }
}