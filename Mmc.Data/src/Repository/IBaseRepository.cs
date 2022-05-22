using System.Linq.Expressions;

namespace Mmc.Data.Repository;

public interface IBaseRepository<T> where T : class
{
    Task<ICollection<T>> GetAllAsync();

    Task<T?> GetByIdAsync(long id);

    IQueryable<T> GetQueryable();

     Task<T> InsertAsync(T t);

    Task Update(T t);
        
     void Delete(T entity);
        
     Task<int> SaveChangesAsync();

     Task<ICollection<T>> FindBy(Expression<Func<T, bool>> predicate);
        
     Task<ICollection<T>> FindAll(Expression<Func<T, bool>> match);

     Task<int> Count();
}