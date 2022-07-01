using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model;
using Mmc.Data.Model.Blog;
using Mmc.Data.Model.User;

namespace Mmc.Data.Repository.Blog;

public class NotificationRepository:BaseRepository<NotificationModel>, INotificationRepository
{
    public NotificationRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<INotification?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id);
    }

    public Task InsertAsync(INotification a)
    {
        var notification = new NotificationModel(a.Body,a.Date,a.Time,a.Status,(NotificationTemplateModel)a.Template,(UserModel)a.User,a.UserType,(ArticleModel)a.Article);
        return base.InsertAsync(notification);
    }

    public async Task<ICollection<INotification>?> GetAllAsync()
    {
        var x = (await base.GetAllAsync()).Cast<INotification>().ToList();
        return x;
    }

    public Task<INotification> GetByGuidAsync(string guid)
    {
        throw new NotImplementedException();
    }

    public IQueryable<INotification> GetQueryable()
    {
        return base.GetQueryable();
    }

    public Task UpdateAsync(INotification blog)
    {
        throw new NotImplementedException();
    }
}
