using Mmc.Core.Repository;

namespace Mmc.Core.Service;

public class OrganizationService
{
    private IKeyValRepository _keyValRepository;

    public OrganizationService(IKeyValRepository keyValRepository)
    {
        _keyValRepository = keyValRepository;
    }
}
