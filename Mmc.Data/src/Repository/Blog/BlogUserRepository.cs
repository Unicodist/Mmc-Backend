using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Data.Model.User;

namespace Mmc.Data.Repository.Blog;

public class BlogUserRepository : BaseRepository<UserModel>, IBlogUserRepository
{
    public BlogUserRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IBlogUser?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id);
    }

    public IBlogUser GetByUsername(string userName)
    {
        return base.GetQueryable().SingleOrDefault(x => x.UserName == userName) ?? throw new UserNotFoundException();
    }
}
