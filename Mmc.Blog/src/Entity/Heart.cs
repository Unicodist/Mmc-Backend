using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Entity;

public class Heart : IHeart
{
    public Heart(IBlogUser user, IArticle article)
    {
        User = user;
        Article = article;
        throw new NotImplementedException();
    }

    public long Id { get; init; }
    public long ArticleId { get; init; }
    public long UserId { get; init; }
    public IBlogUser User { get; set; }
    public IArticle Article { get; set; }
}
