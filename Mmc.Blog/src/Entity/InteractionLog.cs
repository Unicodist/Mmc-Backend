using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class InteractionLog : IInteractionLog
{
    public InteractionLog(IArticle article, IBlogUser user, IComment comment)
    {
        Article = article;
        User = user;
        Comment = comment;
    }

    public InteractionLog(IComment comment, IBlogUser user)
    {
        Comment = comment;
        User = user;
        InteractionType = InteractionType.Comment;
        NewValue = comment.Body;
    }

    public long Id { get; }
    public DateTime DateTime { get; }
    public long UserId { get; }
    public string? OldValue { get; }
    public string NewValue { get; }
    public long? ArticleId { get; }
    public long? CommentId { get; }
    public IArticle? Article { get; set; }
    public IComment? Comment { get; set; }
    public IBlogUser User { get; }
    public InteractionType InteractionType { get; set; }
}
