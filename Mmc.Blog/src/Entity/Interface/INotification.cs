using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity.Interface;

public interface INotification
{
    long Id { get; }
    NotificationStatus Status { get; }
    string Body { get; }
    long? UserId { get; }
    DateOnly Date { get; }
    TimeOnly Time { get; }
    long TemplateId { get; }
    UserType? UserType { get; }
    IBlogUser? User { get; }
    long? ArticleId { get; }
    IArticle? Article { get; }
    INotificationTemplate Template { get; }
}
