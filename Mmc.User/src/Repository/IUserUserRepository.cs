using Mmc.User.Entity.Interface;

namespace Mmc.User.Repository;

public interface IUserUserRepository
{
    Task<IUser> GetUserUserById(long id);
    Task<IUser> InsertAsync(IUser user);
    Task<ICollection<IUser>> GetByName(string name);
    Task<IUser?> GetByUsername(string username);
}
