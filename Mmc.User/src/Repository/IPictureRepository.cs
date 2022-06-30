using Mmc.User.Entity.Interface;

namespace Mmc.User.Repository;

public interface IPictureRepository
{
    Task<IPicture> InsertAsync(IPicture picture);
    Task<ICollection<IPicture>> GetAllAsync();
    Task<IPicture> GetByGuidAsync(string guid);
    IQueryable<IPicture> GetQueryable();
}
