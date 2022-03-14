using Microsoft.EntityFrameworkCore;
using Mmc.Core.Repository;

namespace Mmc.Data.Repository;

public class BaseRepository<T> : BaseRepositoryInterface<T> where T:class
{
    private readonly BaseDbContext _dbContext;
    private readonly DbSet<T> _dbSet;
    
    public BaseRepository(BaseDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }
    
    public async Task<T> Create(T entity)
    {
        await _dbContext.AddAsync(entity);
        return entity;
    }

    public async Task<T?> GetItem(long id)
    {
        return await _dbSet.FindAsync(id).ConfigureAwait(false);
    }

    public Task<T> GetItem(int id)
    {
        throw new NotImplementedException();
    }

    public Task Delete(T entity)
    {
        _dbSet.Remove(entity);
        return Task.CompletedTask;
    }

    public Task DeleteById(long id)
    {
        _dbSet.Remove(_dbSet.Find(id));
        return Task.CompletedTask;
    }

    public IQueryable<T> GetQueryable()
    {
        return _dbSet;
    }

    public Task Update(T entity)
    {
        return Task.FromResult(_dbContext.Update(entity));
    }
}