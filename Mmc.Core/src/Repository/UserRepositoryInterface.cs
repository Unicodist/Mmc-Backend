using Mmc.Core.Entity;

namespace Mmc.Core.Repository;

public interface UserRepositoryInterface
{
    public Task<Boolean> LoginUserWithCredentials(UserCredentials credentials);
    public Task<UserMaster> GetUserById(int Id);
    public Task<IList<UserMaster>> GetUsersByName(string Name);
}