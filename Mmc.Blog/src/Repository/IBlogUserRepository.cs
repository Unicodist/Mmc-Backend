using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface IBlogUserRepository
{
    Task<IBlogUser?> GetBlogUserById(long id);
    IBlogUser GetByUsername(string userName);
}