using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Entity;

public class Upvote : IUpvote
{
    public Upvote(long articleId, long userId, BlogUser user, Article article)
    {
        ArticleId = articleId;
        UserId = userId;
        User = user;
        Article = article;
    }

    public long Id { get; init; }
    public long ArticleId { get; init; }
    public long UserId { get; init; }
    public virtual BlogUser User { get; }
    public virtual Article Article { get; }
    IBlogUser IUpvote.User => User;
    IArticle IUpvote.Article => Article;
}