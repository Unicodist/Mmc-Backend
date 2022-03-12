namespace Mmc.Core.Repository;

public interface BaseRepositoryInterface<T> where T : class
{
    public Task Create(T entity);
    public Task Update(T entity);
    public Task<T> GetItem(long id);
    public Task Delete(T entity);
    public IQueryable<T> GetQueryable();
}