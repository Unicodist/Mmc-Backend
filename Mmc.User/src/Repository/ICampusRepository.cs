using Mmc.User.Entity.Interface;

namespace Mmc.User.Repository;

public interface ICampusRepository
{
    Task<IOrganization> InsertAsync(IOrganization campus);
    Task<IOrganization> GetByGuidAsync(string name);
    Task<ICollection<IOrganization>> GetAllAsync();
}
