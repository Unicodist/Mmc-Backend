using Mmc.Blog.Entity.Interface;

namespace Mmc.Data.Model;

public class NotificationTemplateModel : INotificationTemplate, Mmc.User.Entity.Interface.INotificationTemplate
{
    public NotificationTemplateModel()
    {
    }

    public NotificationTemplateModel(string title, string body)
    {
        Title = title;
        Body = body;
    }

    public long Id { get; set; }
    public string Title { get; }
    public string Body { get; }
}
