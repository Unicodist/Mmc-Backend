using Mmc.User.Enum;

namespace Mmc.User.Entity.Interface;

public interface INotification
{
    long Id { get; }
    NotificationStatus Status { get; }
    long UserId { get; }
    DateOnly Date { get; }
    TimeOnly Time { get; }
    long TemplateId { get; }

    IUser User { get; }
    NotificationTemplate Template { get; }
}