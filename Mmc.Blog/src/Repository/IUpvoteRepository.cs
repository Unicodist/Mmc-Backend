using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface IUpvoteRepository
{
    Task InsertAsync(IHeart heart);
    Task<ICollection<IHeart>?> GetAllAsync();
    IQueryable<IHeart> GetQueryable();
    Task<IHeart?> GetByUserIdAndArticleId(long userId, long articleId);
}
