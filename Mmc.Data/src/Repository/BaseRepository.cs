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
    
    public void Create(T entity)
    {
        _dbContext.Add(entity);
    }

    public void Update(T entity)
    {
        _dbContext.Update(entity);
    }
    
    public void SelectById()
}