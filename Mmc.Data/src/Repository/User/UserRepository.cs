using Microsoft.EntityFrameworkCore;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model.User;
using Mmc.Notice.Entity.Interface;
using Mmc.Notice.Repository;
using Mmc.User.Entity.Interface;
using Mmc.User.Enum;
using Mmc.User.UserException;
using Mmc.User.Repository;

namespace Mmc.Data.Repository.User;

public class UserRepository : BaseRepository<BlogNoticeUserModel>, IUserUserRepository, IBlogUserRepository, INoticeUserRepository
{
    public UserRepository(BaseDbContext dbContext) : base(dbContext)
    {
    }

    #region User

    public async Task<IUser> GetUserUserById(long id)
    {
        return await GetByIdAsync(id).ConfigureAwait(false)??throw new UserNotFoundException();
    }
    public async Task<IUser> InsertAsync(IUser user)
    {
        return await base.InsertAsync((BlogNoticeUserModel) user);
    }
    public IUser CreateInstance(string name, string email, string password, string username)
    {
        return new BlogNoticeUserModel()
        {
            Email = email,
            UserName = username,
            Password = password,
            Name = name,
            UserType = UserType.User
        };
    }
    public Task<IUser?> GetByUsername(string username)
    {
        return Task.FromResult<IUser?>(GetQueryable().SingleOrDefault(x => x.UserName == username));
    }
    public async Task<ICollection<IUser>> GetByName(string name)
    {
        return await GetQueryable().Where(x=>x.Name==name).Cast<IUser>().ToListAsync();
    }

    #endregion

    #region Blog
    
    public async Task<IBlogUser> GetBlogUserById(long id)
    {
        return await GetByIdAsync(id).ConfigureAwait(false)?? throw new UserNotFoundException();
    }

    #endregion

    #region Notice

    public async Task<INoticeUser> GetNoticeUserById(long id)
    {
        return await GetByIdAsync(id).ConfigureAwait(false)?? throw new UserNotFoundException();
    }

    #endregion
}