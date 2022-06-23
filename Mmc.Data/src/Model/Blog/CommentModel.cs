using Mmc.Blog.BaseType;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;
using Mmc.Data.Model.User;

namespace Mmc.Data.Model.Blog;

public class CommentModel : IComment
{
    public CommentModel()
    {
        
    }
    public CommentModel(string body, UserModel user, ArticleModel article, Status status, GuidType commentGuid)
    {
        Body = body;
        User = user;
        Article = article;
        Status = status;
        Guid = commentGuid;
    }

    public long Id { get; protected set; }
    public string Body { get; set; } = null!;
    public long UserId { get; protected set; }
    public long ArticleId { get; protected set; }
    public Status Status { get; set; } = null!;
    public GuidType Guid { get; set; }
    public virtual UserModel User { get; } = null!;
    public virtual ArticleModel Article { get; } = null!;
    IBlogUser IComment.User => User;
    IArticle IComment.Article => Article;
    public void Update(string body)
    {
        Body = body;
    }
    public void FlagAsSuspicious()
    {
        Status = Status.Pending;
    }
}