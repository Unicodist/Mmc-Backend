using Mmc.User.Entity;

namespace Mmc.Core.Repository;

public interface UserRepositoryInterface
{
    public Task<UserMaster> GetUserById(long id);
    public Task<long> CreateUser(UserMaster user);
    public Task<ICollection<UserMaster>> GetUsersByName(string Name);
    public Task RemoveUserById(long id);
}