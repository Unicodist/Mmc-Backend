using Mechi.Backend.ApiModel.Category;
using Mechi.Backend.ViewModel.Blog;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Dto;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mechi.Backend.Controllers.Api;
[ApiController]
[Route("api/[controller]")]
public class CategoryApiController : ControllerBase
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly ICategoryService _categoryService;

    public CategoryApiController(ICategoryRepository categoryRepository, ICategoryService categoryService)
    {
        _categoryRepository = categoryRepository;
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCategoryList()
    {
        var categories = await _categoryRepository.GetAllAsync();
        var model = categories.Select(x => new CategoryResponseModel
        {
            Guid = x.Guid.ToString(),
            Name = x.Name,
            Description = x.Description
        });
        return Ok(model);
    }
    
    public IActionResult Create(CategoryViewModel viewModel)
    {
        var categorydto = new CategoryDto()
        {
            Name = viewModel.Name,
            Description = viewModel.Description
        };
        _categoryService.Create(categorydto);
        return Ok();
    }
    public IActionResult Update(CategoryViewModel viewModel)
    {
        var categorydto = new CategoryDto()
        {
            Guid = viewModel.Guid,
            Name = viewModel.Name,
            Description = viewModel.Description
        };
        _categoryService.Update(categorydto);
        return Ok();
    }
}
