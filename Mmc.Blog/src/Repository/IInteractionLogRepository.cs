using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface IInteractionLogRepository
{
    Task<IInteractionLog?> GetByIdAsync(long id);
    Task Insert(IInteractionLog category);
    Task<ICollection<IInteractionLog>?> GetAll();
    IQueryable<IInteractionLog> GetQueryable();
}