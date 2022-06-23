using Mmc.Blog.BaseType;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class Comment : IComment
{
    public Comment()
    {
        
    }
    public Comment(string body,IBlogUser user, IArticle article)
    {
        User = user;
        Body = body;
        Status = Status.Active;
        User = user;
        Article = article;
        Guid = new GuidType();
    }

    public long Id { get; protected set; }
    public string Body { get; set; } = null!;
    public long UserId { get; set; }
    public long ArticleId { get; set; }
    public Status Status { get; set; } = null!;
    public IBlogUser User { get; } = null!;
    public IArticle Article { get; } = null!;
    public GuidType Guid { get; }

    public void Update(string body)
    {
        Body = body;
    }

    public void FlagAsSuspicious()
    {
        Status = Status.Pending;
    }
}
