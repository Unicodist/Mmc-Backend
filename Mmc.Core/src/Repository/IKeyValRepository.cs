using Mmc.Core.Entity.Interface;

namespace Mmc.Core.Repository;

public interface IKeyValRepository
{
    Task<string> GetByKey(string key);
    Task SetByKey(string key, string value);
    IOrganization GetOrgInstance(string name, string subtitle, string country, string vdc, string state, string ward);
}