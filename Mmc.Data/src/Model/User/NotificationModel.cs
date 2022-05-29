using Mmc.User.Entity;
using Mmc.User.Entity.Interface;
using Mmc.User.Enum;

namespace Mmc.Data.Model.User;

public class NotificationModel : INotification
{
    public long Id { get; set; }
    public NotificationStatus Status { get; set; }
    public long UserId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public long TemplateId { get; set; }
    public virtual UserModel User { get; set; }
    IUser INotification.User => User;
    public virtual NotificationTemplate Template { get; set; }
}