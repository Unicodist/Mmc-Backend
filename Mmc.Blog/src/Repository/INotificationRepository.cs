using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface INotificationRepository
{
    Task<INotification?> GetByIdAsync(long id);
    Task InsertAsync(INotification a);
    Task<ICollection<INotification>?> GetAllAsync();
    Task<INotification> GetByGuidAsync(string guid);
    IQueryable<INotification> GetQueryable();
    Task UpdateAsync(INotification blog);
}
