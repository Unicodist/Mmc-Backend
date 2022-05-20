using Mmc.Core.Entity.Interface;

namespace Mmc.Core.Repository;

public interface IOrgRepository
{
    Task<IOrganization> GetOrganization();
    Task Update(IOrganization org);
}