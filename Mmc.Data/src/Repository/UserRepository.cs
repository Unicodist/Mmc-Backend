using Microsoft.EntityFrameworkCore;
using Mmc.Core.Repository;
using Mmc.Data.Model.User;
using Mmc.User.Entity;
using Mmc.User.Entity.Interface;
using Mmc.User.Enum;
using Mmc.User.Exception;

namespace Mmc.Data.Repository;

public class UserRepository : BaseRepository<UserModel>, UserRepositoryInterface
{
    public UserRepository(BaseDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IUser> GetById(long id)
    {
        return await base.GetById(id).ConfigureAwait(false)??throw new UserNotFoundException();
    }

    public Task Insert(IUser user)
    {
        return base.Insert((UserModel) user);
    }

    public IUser CreateInstance(string name, string email, string password, string username)
    {
        return new UserModel()
        {
            Email = email,
            UserName = username,
            Password = password,
            Name = name,
            UserType = UserType.User
        };
    }

    public async Task<ICollection<IUser>> GetByName(string Name)
    {
        return await GetQueryable().Where(x=>x.Name==Name).Cast<IUser>().ToListAsync();
    }
}