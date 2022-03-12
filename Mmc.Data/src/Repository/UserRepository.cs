using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Mmc.Core.Entity;
using Mmc.Core.Repository;

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

    public Task<bool> LoginUserWithCredentials(UserCredentials credentials)
    {
        throw new NotImplementedException();
    }

    public async Task<ICollection<UserMaster>> GetUsersByName(string Name)
    {
        return await GetQueryable().ToListAsync();
    }

    public Task RemoveUserById(long id)
    {
        throw new NotImplementedException();
    }
}