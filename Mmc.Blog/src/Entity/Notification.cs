using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class Notification : INotification
{
    public Notification(INotificationTemplate template, string body, IArticle commentArticle)
    {
        Template = template;
        Body = body;
        Article = commentArticle;
        Date = DateOnly.MaxValue;
        Time = TimeOnly.MaxValue;
        Status = NotificationStatus.UNREAD;
        UserType = UserType.ADMIN;
    }

    public long Id { get; }
    public NotificationStatus Status { get; }
    public string Body { get; set; }
    public long? UserId { get; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public long TemplateId { get; }
    public UserType? UserType { get; set; }
    public IBlogUser? User { get; }
    public long? ArticleId { get; }
    public IArticle? Article { get; }
    public INotificationTemplate Template { get; }
}
