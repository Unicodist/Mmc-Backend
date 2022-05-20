using Mmc.Core.Entity.Interface;
using Mmc.Core.Repository;
using Mmc.Data.Model.Core;

namespace Mmc.Data.Repository;

public class KeyValRepository : IKeyValRepository
{
    public Task<string> GetByKey(string key)
    {
        throw new NotImplementedException();
    }

    public Task SetByKey(string key, string value)
    {
        throw new NotImplementedException();
    }

    public IOrganization GetOrgInstance(string name, string subtitle, string country, string vdc, string state, string ward)
    {
        return new OrganizationModel(name, subtitle, country, vdc, state, ward);
    }
}