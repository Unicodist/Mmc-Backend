using Microsoft.EntityFrameworkCore;
using Mmc.Core.Repository;
using Mmc.User.Entity;

namespace Mmc.Data.Repository;

public class UserRepository : BaseRepository<UserMaster>, UserRepositoryInterface
{
    public UserRepository(BaseDbContext dbContext) : base(dbContext)
    {
    }



    public Task<UserMaster?> GetUserById(long id)
    {
        return GetItem(id);
    }

    public async Task<ICollection<UserMaster>> GetUsersByName(string Name)
    {
        return await GetQueryable().ToListAsync();
    }

    public Task RemoveUserById(long id)
    {
        base.DeleteById(id);
        return Task.CompletedTask;
    }

    public Task<long> CreateUser(UserMaster user)
    {
        Task<UserMaster> um = Create(user);
        return Task.FromResult(um.Result.UserMasterId);
    }
}