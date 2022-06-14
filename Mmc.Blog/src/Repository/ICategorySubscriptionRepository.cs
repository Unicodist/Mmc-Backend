using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface ICategorySubscriptionRepository
{
    public Task<ICategorySubscription?> GetByIdAsync(long id);
    public Task InsertAsync(ICategorySubscription cs);
    public Task UpdateAsync(ICategorySubscription cs);
}