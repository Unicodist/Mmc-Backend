using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Data.Model.Blog;

public class InteractionLogModel : IInteractionLog
{
    public long Id { get; }
    public DateTime DateTime { get; }
    public long UserId { get; set; }
    public string OldValue { get; set; }
    public string NewValue { get; set; }
    public InteractionAction Action { get; set; }
    public long? ArticleId { get; set; }
    public long? CommentId { get; set; }
    
    public virtual ArticleModel? Article { get; set; }
    public virtual CommentModel? Comment { get; set; }

    IArticle? IInteractionLog.Article => Article;

    IComment? IInteractionLog.Comment => Comment;
}