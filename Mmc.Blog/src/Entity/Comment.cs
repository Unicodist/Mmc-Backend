using Mmc.Blog.BaseType;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class Comment : IComment
{
    public Comment()
    {
        
    }
    public Comment(long userId, string body, Status status, IBlogUser user, IArticle article, IComment parent, GuidType guid)
    {
        UserId = userId;
        Body = body;
        Status = status;
        User = user;
        Article = article;
        Parent = parent;
        Guid = guid;
    }

    public long Id { get; }
    public string Body { get; set; } = null!;
    public long UserId { get; }
    public long ArticleId { get; }
    public long ParentId { get; }
    public Status Status { get; set; } = null!;
    public IBlogUser User { get; } = null!;
    public IArticle Article { get; } = null!;
    public IComment? Parent { get; }
    public ICollection<IComment>? Replies { get; }
    public GuidType Guid { get; } = null!;

    public void Update(string body)
    {
        Body = body;
    }
}