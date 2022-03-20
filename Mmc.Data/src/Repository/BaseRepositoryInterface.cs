using System.Linq.Expressions;

namespace Mmc.Data.Repository;

public interface BaseRepositoryInterface<T> where T : class
{
    public Task<List<T>> GetAll();

    public Task<T?> GetById(long id);

    public IQueryable<T> GetQueryable();

    public Task Insert(T t);

    public void Update(T t);
        
    public void Delete(T entity);
        
    public Task<int> SaveChangesAsync();

    public Task<ICollection<T>> FindBy(Expression<Func<T, bool>> predicate);
        
    public Task<ICollection<T>> FindAll(Expression<Func<T, bool>> match);

    public Task<int> Count();
}