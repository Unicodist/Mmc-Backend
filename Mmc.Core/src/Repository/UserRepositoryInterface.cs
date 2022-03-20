using Mmc.User.Entity;

namespace Mmc.Core.Repository;

public interface UserRepositoryInterface
{
    public Task<UserMasterEntity> GetById(long id);
    public Task Insert(UserMasterEntity user);
    public Task<ICollection<UserMasterEntity>> GetByName(string Name);
}