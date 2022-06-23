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

public class UserRepository : BaseRepository<UserModel>, IUserUserRepository, IBlogUserRepository, INoticeUserRepository
{
    public UserRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    #region User

    public async Task<IUser> GetUserUserById(long id)
    {
        return await GetByIdAsync(id).ConfigureAwait(false)??throw new UserNotFoundException();
    }
    public async Task<IUser> InsertAsync(IUser user)
    {
        var uModel = new UserModel(user.Name, user.UserType, user.Email, user.Password, user.UserName, user.Picture);
        await base.InsertAsync(uModel);
        return uModel;
    }
    public IUser CreateInstance(string name, string email, string password, string username)
    {
        return new UserModel
        {
            Email = email,
            UserName = username,
            Password = password,
            Name = name,
            UserType = UserType.USER
        };
    }
    public IUser? GetByUsername(string username)
    {
        return GetQueryable().SingleOrDefault(x => x.UserName == username);
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

    IBlogUser? IBlogUserRepository.GetByUsername(string userName) => (UserModel)GetByUsername(userName);

    #endregion

    #region Notice

    public async Task<INoticeUser> GetNoticeUserById(long id)
    {
        return await GetByIdAsync(id).ConfigureAwait(false)?? throw new UserNotFoundException();
    }

    #endregion
}