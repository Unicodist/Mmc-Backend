using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
namespace Mmc.Data.Repository;

public class BaseRepository<T> : BaseRepositoryInterface<T> where T:class
{
    private readonly BaseDbContext _dbContext;
    private readonly DbSet<T> _dbSet;


    public BaseRepository(BaseDbContext context)
    {
        _dbContext = context;
        _dbSet = _dbContext.Set<T>();
    }

    public async Task<List<T>> GetAll()
    {
        return await _dbSet.ToListAsync().ConfigureAwait(false)??new List<T>();
    }

    public async Task<T?> GetById(long id)
    {
        return await _dbSet.FindAsync(id).ConfigureAwait(false);
    }

    public IQueryable<T> GetQueryable()
    {
        return _dbSet;
    }

    public async Task Insert(T t)
    {
        await _dbSet.AddAsync(t).ConfigureAwait(false);
        await _dbContext.SaveChangesAsync().ConfigureAwait(false);
    }

    public async Task Update(T t)
    {
        _dbSet.Update(t);
        await _dbContext.SaveChangesAsync().ConfigureAwait(false);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
        _dbContext.SaveChanges();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _dbContext.SaveChangesAsync().ConfigureAwait(false);
    }

    public async Task<ICollection<T>> FindBy(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync().ConfigureAwait(false);
    }

    public Task<ICollection<T>> FindAll(Expression<Func<T, bool>> match)
    {
        throw new NotImplementedException();
    }

    public async Task<int> Count()
    {
        return await _dbSet.CountAsync().ConfigureAwait(false);
    }
}