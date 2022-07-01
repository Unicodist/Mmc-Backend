using Mechi.Backend.Helper;
using Mechi.Backend.ViewModel.Blog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Repository;

namespace Mechi.Backend.Controllers.Blog;

public class SetupController : Controller
{
    private readonly ICategoryRepository _categoryRepository;

    // GET
    public SetupController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    [Authorize]
    public IActionResult Index()
    {
        if (User.GetRole()!="SuperAdmin")
        {
            return Problem("You are not authorized");
        }
        return View();
    }

    public async Task<PartialViewResult> GetCategoryDetails(string guid)
    {
        var category = await _categoryRepository.GetByGuid(guid);
        var model = new CategoryViewModel()
        {
            Description = category.Description, Guid = category.Guid.ToString(), Name = category.Name
        };
        return PartialView("PartialViews/Setup/CategoryForm",model);
    }
}
