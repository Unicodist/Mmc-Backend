using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Service.Interface;

public interface INotificationService
{
    Task CreateToxicComment(IComment comment);
}
