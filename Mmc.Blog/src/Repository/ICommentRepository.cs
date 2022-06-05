using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface ICommentRepository
{
    Task<IComment?> GetByIdAsync(long id);
    Task Insert(IComment category);
    Task<ICollection<IComment>?> GetAll();
    IQueryable<IComment> GetQueryable();

    Task<ICollection<IComment>> GetByArticleIdAsync(long id);
}