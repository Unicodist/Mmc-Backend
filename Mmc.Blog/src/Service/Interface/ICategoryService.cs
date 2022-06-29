using Mmc.Blog.Dto;
using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Service.Interface;

public interface ICategoryService
{
    public Task Create(CategoryDto dto);
    public Task Update(CategoryDto dto);
}
