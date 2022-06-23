using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Entity;

public class Like : ILike
{
    public long Id { get; }
    public long UserId { get; }
    public long ArticleId { get; }
    public IArticle Article { get; }
    public IBlogUser User { get; }
}
