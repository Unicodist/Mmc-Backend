using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface IUpvoteRepository
{
    Task InsertAsync(IUpvote upvote);
    Task<ICollection<IUpvote>?> GetAllAsync();
    IQueryable<IUpvote> GetQueryable();
    Task<IUpvote?> GetByUserIdAndArticleId(long userId, long articleId);
}
