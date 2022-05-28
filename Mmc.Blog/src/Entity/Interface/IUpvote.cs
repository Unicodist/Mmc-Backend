namespace Mmc.Blog.Entity.Interface;

public interface IUpvote
{
    long Id { get; }
    long ArticleId { get; }
    long UserId { get; }
    
    IBlogUser User { get; }
    IArticle Article { get; }
}