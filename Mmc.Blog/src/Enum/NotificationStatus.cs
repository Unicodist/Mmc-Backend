namespace Mmc.Blog.Enum;

public class NotificationStatus : BaseEnum
{
    public static readonly NotificationStatus READ = new(1, Read);
    public static readonly NotificationStatus DELIVERED = new(2, Delivered);
    public static readonly NotificationStatus UNREAD = new(2, Unread);
    private const string Read = "Read";
    private const string Delivered = "Delivered";
    private const string Unread = "Unread";

    private NotificationStatus(int id, string value): base(id, value)
    {
        
    }
    public static implicit operator string(NotificationStatus value)=>value.Value;
    public static implicit operator NotificationStatus(string value)=>GetAll<NotificationStatus>().SingleOrDefault(x => x.ToString() == value)??DELIVERED;
}
