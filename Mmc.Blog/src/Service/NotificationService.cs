using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mmc.Blog.Service;

public class NotificationService : INotificationService
{
    private readonly INotificationTemplateRepository _templateRepository;
    private readonly INotificationRepository _notificationRepo;

    public NotificationService(INotificationTemplateRepository templateRepository, INotificationRepository notificationRepo)
    {
        _templateRepository = templateRepository;
        _notificationRepo = notificationRepo;
    }

    public async Task CreateToxicComment(IComment comment)
    {
        var template = await _templateRepository.GetByIdAsync(1);
        var body = string.Format(template.Body, comment.User.UserName);
        var notification = new Notification(template,body,comment.Article);
        await _notificationRepo.InsertAsync(notification);
    }
}
