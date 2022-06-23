using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class InteractionLog : IInteractionLog
{
    public long Id { get; }
    public DateTime DateTime { get; }
    public long UserId { get; }
    public string OldValue { get; }
    public string NewValue { get; }
    public long? ArticleId { get; }
    public long? CommentId { get; }
    public Article? Article { get; set; }
    public Comment? Comment { get; set; }
    public InteractionType InteractionType { get; set; }
    IArticle? IInteractionLog.Article => Article;
    IComment? IInteractionLog.Comment => Comment;
}
