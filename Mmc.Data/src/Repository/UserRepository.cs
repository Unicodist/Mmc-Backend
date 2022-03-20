using Microsoft.EntityFrameworkCore;
using Mmc.Core.Repository;
using Mmc.User.Entity;

namespace Mmc.Data.Repository;

public class UserRepository : BaseRepository<UserMasterEntity>, UserRepositoryInterface
{
    public UserRepository(BaseDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<ICollection<UserMasterEntity>> GetByName(string Name)
    {
        return await GetQueryable().Where(x=>x.UserMasterName==Name).ToListAsync();
    }
}