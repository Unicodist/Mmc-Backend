using Mmc.User.Entity.Interface;

namespace Mmc.User.Repository;

public interface IUserRepository
{
    public Task<IUser> GetById(long id);
    public Task<IUser> InsertAsync(IUser user);
    public Task<ICollection<IUser>> GetByName(string name);
    IUser CreateInstance(string name, string email, string password, string username);
    Task<IUser?> GetByUsername(string username);
}