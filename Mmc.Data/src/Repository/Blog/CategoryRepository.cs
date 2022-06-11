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
        return base.InsertAsync((CategoryModel) category);
    }

    public new async Task<ICollection<ICategory>?> GetAllAsync()
    {
        return (await base.GetAllAsync().ConfigureAwait(false)).Cast<ICategory>().ToList();
    }

    public Task<ICategory?> GetByGuid(string dtoCategoryGuid)
    {
        return Task.FromResult<ICategory?>(GetQueryable().SingleOrDefault(x => x.Guid.Equals(dtoCategoryGuid)));
    }
}