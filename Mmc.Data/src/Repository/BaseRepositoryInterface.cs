using System.Linq.Expressions;

namespace Mmc.Data.Repository;

public interface BaseRepositoryInterface<T> where T : class
{
    Task<List<T>> GetAll();

    Task<T?> GetById(long id);

    IQueryable<T> GetQueryable();

     Task Insert(T t);

    Task Update(T t);
        
     void Delete(T entity);
        
     Task<int> SaveChangesAsync();

     Task<ICollection<T>> FindBy(Expression<Func<T, bool>> predicate);
        
     Task<ICollection<T>> FindAll(Expression<Func<T, bool>> match);

     Task<int> Count();
}