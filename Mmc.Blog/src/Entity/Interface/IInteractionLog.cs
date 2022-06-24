using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity.Interface;

public interface IInteractionLog
{
    long Id { get; }
    DateTime DateTime { get; }
    long UserId { get; }
    string OldValue { get; }
    string NewValue { get; }
    long? ArticleId { get; }
    long? CommentId { get; }
    
    IArticle? Article { get; }
    IComment Comment { get; }
    IBlogUser User { get; }
    InteractionType InteractionType { get; set; }
}
