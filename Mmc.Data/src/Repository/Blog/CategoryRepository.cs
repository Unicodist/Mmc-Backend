using Microsoft.EntityFrameworkCore;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Repository.Blog;

public class CategoryRepository :BaseRepository<CategoryModel>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }
    
    public new async Task<ICategory?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id).ConfigureAwait(false);
    }

    public Task InsertAsync(ICategory category)
    {
        var model = new CategoryModel(category.Name,category.Description,category.Guid,category.Status);
        return base.InsertAsync((CategoryModel) category);
    }

    public new async Task<ICollection<ICategory>?> GetAllAsync()
    {
        return (await base.GetAllAsync().ConfigureAwait(false)).Cast<ICategory>().ToList();
    }

    public async Task<ICategory?> GetByGuid(string dtoCategoryGuid)
    {
        return await GetQueryable().SingleOrDefaultAsync(x => x.Guid == dtoCategoryGuid);
    }

    public Task UpdateAsync(ICategory category)
    {
        return base.UpdateAsync((CategoryModel)category);
    }
}
