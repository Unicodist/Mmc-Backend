using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Repository.Blog;

public class CategorySubscriptionRepository :BaseRepository<CategorySubscriptionModel>, ICategorySubscriptionRepository
{
    
    public CategorySubscriptionRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<ICategorySubscription?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id);
    }

    public Task InsertAsync(ICategorySubscription cs)
    {
        var cats = new CategorySubscriptionModel(cs.User,cs.Category);
        return base.InsertAsync(cats);
    }

    public Task UpdateAsync(ICategorySubscription cs)
    {
        return base.Update((CategorySubscriptionModel) cs);
    }
}