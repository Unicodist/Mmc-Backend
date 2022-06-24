using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface IBlogUserRepository
{
    Task<IBlogUser?> GetByIdAsync(long id);
    IBlogUser GetByUsername(string userName);
}
