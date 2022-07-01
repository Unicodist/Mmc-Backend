using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model;

namespace Mmc.Data.Repository.Blog;

public class NotificationTemplateRepository : BaseRepository<NotificationTemplateModel>, INotificationTemplateRepository
{
    public NotificationTemplateRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<INotificationTemplate> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id);
    }

    public Task<INotificationTemplate> GetByTypeAsync(string type)
    {
        throw new NotImplementedException();
    }
}
