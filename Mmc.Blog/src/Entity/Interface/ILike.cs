namespace Mmc.Blog.Entity.Interface;

public interface ILike
{
    long Id { get; }
    long UserId { get; }
    long ArticleId { get; }
    IArticle Article { get; }
    IBlogUser User { get; }
}
