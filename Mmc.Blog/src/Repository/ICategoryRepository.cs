using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface ICategoryRepository
{
    public Task<ICategory?> GetByIdAsync(long id);
    public Task InsertAsync(ICategory category);
    public Task<ICollection<ICategory>?> GetAllAsync();
    Task<ICategory?> GetByGuid(string dtoCategoryGuid);
    Task UpdateAsync(ICategory category);
}