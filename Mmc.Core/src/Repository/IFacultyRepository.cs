using Mmc.Core.Entity.Interface;

namespace Mmc.Core.Repository;

public interface IFacultyRepository
{
    Task<IFaculty?> GetByIdAsync(long id);
    Task<IFaculty> InsertAsync(IFaculty entity);
    Task<ICollection<IFaculty>?> GetAllAsync();
    IQueryable<IFaculty> GetQueryable();

    Task<ICollection<IFaculty>> GetByArticleIdAsync(long id);
    Task<IFaculty?> GetByGuidAsync(string guid);
    Task UpdateAsync(IFaculty comment);
}
