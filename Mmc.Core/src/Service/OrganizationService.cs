using Mmc.Core.Dto;
using Mmc.Core.Entity.Interface;
using Mmc.Core.Helper;
using Mmc.Core.Repository;

namespace Mmc.Core.Service;

public class OrganizationService
{
    private IKeyValRepository _keyValRepository;

    public OrganizationService(IKeyValRepository keyValRepository)
    {
        _keyValRepository = keyValRepository;
    }

    public Task Update(OrgUpdateDto dto)
    {
        using var tx = TransactionScopeHelper.GetInstance;
        _keyValRepository.SetByKey(nameof(IOrganization.Name), dto.Name);
        _keyValRepository.SetByKey(nameof(IOrganization.Subtitle), dto.Subtitle);
        _keyValRepository.SetByKey(nameof(IOrganization.Country), dto.Country);
        _keyValRepository.SetByKey(nameof(IOrganization.State), dto.State);
        _keyValRepository.SetByKey(nameof(IOrganization.Vdc), dto.Vdc);
        _keyValRepository.SetByKey(nameof(IOrganization.Ward), dto.Ward);
        tx.Complete();
        return Task.CompletedTask;
    }
}
