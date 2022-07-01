namespace Mmc.User.Entity;

public class NotificationTemplate
{
    public NotificationTemplate(string title, string body)
    {
        Title = title;
        Body = body;
    }

    public long Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}
