using Microsoft.EntityFrameworkCore;
using Mmc.Core.Repository;
using Mmc.Data.Model.User;
using Mmc.User.Entity.Interface;
using Mmc.User.Enum;
using Mmc.User.UserException;
using Mmc.User.Repository;

namespace Mmc.Data.Repository.User;

public class UserRepository : BaseRepository<UserModel>, IUserRepository
{
    public UserRepository(BaseDbContext dbContext) : base(dbContext)
    {
    }

    public new async Task<IUser> GetById(long id)
    {
        return await base.GetById(id).ConfigureAwait(false)??throw new UserNotFoundException();
    }

    public async Task<IUser> InsertAsync(IUser user)
    {
        return await base.InsertAsync((UserModel) user);
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

    public Task<IUser?> GetByUsername(string username)
    {
        return Task.FromResult<IUser?>(GetQueryable().SingleOrDefault(x => x.UserName == username));
    }

    public async Task<ICollection<IUser>> GetByName(string name)
    {
        return await GetQueryable().Where(x=>x.Name==name).Cast<IUser>().ToListAsync();
    }
}