using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface ICommentRepository
{
    Task<IComment?> GetByIdAsync(long id);
    Task InsertAsync(IComment category);
    Task<ICollection<IComment>?> GetAllAsync();
    IQueryable<IComment> GetQueryable();

    Task<ICollection<IComment>> GetByArticleIdAsync(long id);
    Task<IComment?> GetByGuidAsync(string guid);
}
