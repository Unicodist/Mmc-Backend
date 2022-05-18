using Mmc.User.Entity;
using Mmc.User.Entity.Interface;

namespace Mmc.Core.Repository;

public interface UserRepositoryInterface
{
    public Task<IUser> GetById(long id);
    public Task Insert(IUser user);
    public Task<ICollection<IUser>> GetByName(string Name);
    IUser CreateInstance(string name, string email, string password, string username);
}