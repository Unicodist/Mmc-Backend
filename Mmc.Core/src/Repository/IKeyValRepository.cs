namespace Mmc.Core.Repository;

public interface IKeyValRepository
{
    Task<string> GetByKey(string key);
    Task SetByKey(string key, string value);
}
