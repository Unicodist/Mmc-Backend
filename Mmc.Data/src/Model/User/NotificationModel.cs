using Mmc.Blog.Entity.Interface;
using Mmc.Data.Model.Blog;
using Mmc.User.Entity;
using Mmc.User.Entity.Interface;
using Mmc.User.Enum;
using INotification = Mmc.User.Entity.Interface.INotification;
using INotificationTemplate = Mmc.Blog.Entity.Interface.INotificationTemplate;
using NotificationStatus = Mmc.Blog.Enum.NotificationStatus;
using UserType = Mmc.Core.Enum.UserType;

namespace Mmc.Data.Model.User;

public class NotificationModel : INotification, Mmc.Blog.Entity.Interface.INotification
{
    public NotificationModel()
    {
    }

    public NotificationModel(string aBody, DateOnly aDate, TimeOnly aTime, NotificationStatus aStatus, NotificationTemplateModel aTemplate, UserModel aUser, Mmc.Blog.Enum.UserType aUserType,ArticleModel article)
    {
        Body = aBody;
        Date = aDate;
        Time = aTime;
        Status = aStatus;
        Template = aTemplate;
        User = aUser;
        UserType = aUserType;
        Article = article;
    }

    public long Id { get; set; }
    public string Status { get; set; }
    public string Body { get; set; }
    Mmc.User.Enum.NotificationStatus INotification.Status => Status;
    Mmc.Blog.Enum.NotificationStatus Mmc.Blog.Entity.Interface.INotification.Status => Status;
    public long? UserId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public long TemplateId { get; set; }
    public virtual UserModel? User { get; set; }
    public long? ArticleId { get; set; }
    public virtual ArticleModel? Article { get; set; }
    IArticle Mmc.Blog.Entity.Interface.INotification.Article => Article;
    public string? UserType { get; set; }
    Mmc.User.Enum.UserType? INotification.UserType => UserType;
    Mmc.Blog.Enum.UserType? Mmc.Blog.Entity.Interface.INotification.UserType => UserType;
    IUser? INotification.User => User;
    IBlogUser? Mmc.Blog.Entity.Interface.INotification.User => User;
    public virtual NotificationTemplateModel Template { get; set; }
    INotificationTemplate Mmc.Blog.Entity.Interface.INotification.Template => Template;
    Mmc.User.Entity.Interface.INotificationTemplate INotification.Template => Template;
}
