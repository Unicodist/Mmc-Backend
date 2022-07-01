using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface INotificationTemplateRepository
{
    Task<INotificationTemplate> GetByIdAsync(long id);
    Task<INotificationTemplate> GetByTypeAsync(string type);
}
