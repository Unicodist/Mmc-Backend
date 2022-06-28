using Mmc.User.Entity.Interface;

namespace Mmc.User.Repository;

public interface IPictureRepository
{
    Task<IPicture> InsertAsync(IPicture picture);
    Task<IPicture> GetByUsername(string name);
    Task<ICollection<IPicture>> GetAllAsync();
    Task<IPicture> GetByGuidAsync(string guid);
}
