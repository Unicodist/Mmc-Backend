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
        _keyValRepository.SetByKey(nameof(IOrganization.OrganizationName), dto.Name);
        _keyValRepository.SetByKey(nameof(IOrganization.OrganizationSubtitle), dto.Subtitle);
        _keyValRepository.SetByKey(nameof(IOrganization.OrganizationCountry), dto.Country);
        _keyValRepository.SetByKey(nameof(IOrganization.OrganizationState), dto.State);
        _keyValRepository.SetByKey(nameof(IOrganization.OrganizationVdc), dto.Vdc);
        _keyValRepository.SetByKey(nameof(IOrganization.OrganizationWard), dto.Ward);
        tx.Complete();
        return Task.CompletedTask;
    }

    public async Task<IOrganization> GetOrganization()
    {
        var Name = await _keyValRepository.GetByKey(nameof(IOrganization.OrganizationName));
        var Subtitle = await _keyValRepository.GetByKey(nameof(IOrganization.OrganizationSubtitle));
        var Country = await _keyValRepository.GetByKey(nameof(IOrganization.OrganizationCountry));
        var Vdc = await _keyValRepository.GetByKey(nameof(IOrganization.OrganizationVdc));
        var State = await _keyValRepository.GetByKey(nameof(IOrganization.OrganizationState));
        var Ward = await _keyValRepository.GetByKey(nameof(IOrganization.OrganizationWard));
        return _keyValRepository.GetOrgInstance(Name, Subtitle, Country, Vdc, State, Ward);
    }
}