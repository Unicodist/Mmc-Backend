using Mmc.Blog.Dto;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mmc.Blog.Service;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task Create(CategoryDto dto)
    {
        var category = new Category(dto.Name,dto.Description);
        await _categoryRepository.InsertAsync(category);
        
    }

    public async Task Update(CategoryDto dto)
    {
        var category = await _categoryRepository.GetByGuid(dto.Guid) ?? throw new CategoryNotFoundException();
        category.Update(dto.Name,dto.Description);
        await _categoryRepository.UpdateAsync(category);
    }
}
