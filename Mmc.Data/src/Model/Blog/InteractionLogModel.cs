using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;
using Mmc.Data.Model.User;

namespace Mmc.Data.Model.Blog;

public class InteractionLogModel : IInteractionLog
{
    public InteractionLogModel()
    {
    }

    public InteractionLogModel(ArticleModel? interactionArticle, CommentModel? interactionComment, UserModel interactionUser, InteractionType interactionInteractionType, string interactionOldValue, string interactionNewValue, DateTime interactionDateTime)
    {
        Article = interactionArticle;
        Comment = interactionComment;
        User = interactionUser;
        InteractionType = interactionInteractionType;
        OldValue = interactionOldValue;
        NewValue = interactionNewValue;
        DateTime = interactionDateTime;
    }

    public long Id { get; }
    public DateTime DateTime { get; }
    public long UserId { get; set; }
    public string? OldValue { get; set; }
    public string NewValue { get; set; }
    public long? ArticleId { get; set; }
    public long? CommentId { get; set; }
    
    public virtual ArticleModel? Article { get; set; }
    public virtual CommentModel? Comment { get; set; }

    public virtual UserModel User { get; set; }
    IBlogUser IInteractionLog.User => User;
    public InteractionType InteractionType { get; set; }

    IArticle? IInteractionLog.Article => Article;

    IComment? IInteractionLog.Comment => Comment;
}
