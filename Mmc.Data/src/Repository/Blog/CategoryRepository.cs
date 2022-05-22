using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Repository.Blog;

public class CategoryRepository :BaseRepository<CategoryModel>, ICategoryRepository
{
    public CategoryRepository(BaseDbContext context) : base(context)
    {
    }
    
    public async Task<ICategory?> GetById(long id)
    {
        return await base.GetByIdAsync(id).ConfigureAwait(false);
    }

    public Task Insert(ICategory category)
    {
        return base.InsertAsync((CategoryModel) category);
    }

    public async Task<ICollection<ICategory>?> GetAll()
    {
        return (await base.GetAllAsync().ConfigureAwait(false)).Cast<ICategory>().ToList();
    }

    public ICategory CreateInstance(string name, string description)
    {
        return new CategoryModel(name, description);
    }

}