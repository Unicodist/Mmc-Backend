using Mmc.Core.Entity.Interface;

namespace Mmc.Core.Repository;

public interface ICourseRepository
{
    Task<ICourse?> GetByIdAsync(long id);
    Task<ICourse> InsertAsync(ICourse entity);
    Task<ICollection<ICourse>?> GetAllAsync();
    IQueryable<ICourse> GetQueryable();

    Task<ICollection<ICourse>> GetByArticleIdAsync(long id);
    Task<ICourse?> GetByGuidAsync(string guid);
    Task UpdateAsync(ICourse comment);
}
