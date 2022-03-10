namespace Mmc.Core.Repository;

public interface BaseRepositoryInterface<T> where T : class
{
    public void Create(T entity);
    public void Update(T entity);
}