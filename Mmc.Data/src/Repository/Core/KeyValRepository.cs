using Mmc.Core.Repository;

namespace Mmc.Data.Repository.Core;

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
}
