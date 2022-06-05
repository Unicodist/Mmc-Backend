using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface IUpvoteRepository
{
    Task<IUpvote?> GetByIdAsync(long id);
    Task InsertAsync(IUpvote category);
    Task<ICollection<IUpvote>?> GetAllAsync();
    IQueryable<IUpvote> GetQueryable();
}