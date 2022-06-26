using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface IHeartRepository
{
    Task InsertAsync(IHeart heart);
    Task<ICollection<IHeart>?> GetAllAsync();
    Task<ICollection<IHeart>?> GetAllByBlogIdAsync(long articleId);
    Task<bool> GetByUserIdAndArticleId(long userId, long articleId);
    Task<int> GetHeartCountByArticleId(long articleId);
}
