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
    
    public Task Create(T entity)
    {
        return Task.FromResult(_dbContext.Add(entity));
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
        return Task.FromResult(_dbSet.Remove(entity));
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