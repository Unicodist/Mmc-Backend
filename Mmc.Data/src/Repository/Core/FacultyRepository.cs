using Mmc.Core.Entity.Interface;
using Mmc.Core.Repository;
using Mmc.Data.Model.Core;

namespace Mmc.Data.Repository.Core;

public class FacultyRepository : BaseRepository<FacultyModel>,IFacultyRepository
{
    public Task<IFaculty?> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IFaculty> InsertAsync(IFaculty entity)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<IFaculty>?> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public IQueryable<IFaculty> GetQueryable()
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<IFaculty>> GetByArticleIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IFaculty?> GetByGuidAsync(string guid)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(IFaculty comment)
    {
        throw new NotImplementedException();
    }

    public FacultyRepository(AppDbContext context) : base(context)
    {
    }
}
