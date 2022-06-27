using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface ISuspiciousCommentRepository
{
    Task<IToxicComment> InsertAsync(IToxicComment comment);
    Task<ICollection<IToxicComment>?> GetAllAsync();
    Task<ICollection<IToxicComment>?> GetAllByBlogIdAsync(long articleId);
    Task<ICollection<IToxicComment>?> GetAllByUserIdAsync(long userId);
    Task<ICollection<IToxicComment>> GetByUserIdAndArticleId(long userId, long articleId);
    Task<int> GetCountByArticleId(long articleId);
}
