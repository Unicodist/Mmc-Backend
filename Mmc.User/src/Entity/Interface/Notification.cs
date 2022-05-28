using Mmc.User.Entity.Interface;
using Mmc.User.Enum;

namespace Mmc.User.Entity;

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