using Mmc.Core.Entity.Interface;
using Mmc.Core.Repository;
using Mmc.Data.Model.Core;

namespace Mmc.Data.Repository.Core;

public class CourseRepository : BaseRepository<CourseModel>, ICourseRepository
{
    public CourseRepository(AppDbContext context) : base(context)
    {
    }

    public Task<ICourse?> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<ICourse> InsertAsync(ICourse entity)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<ICourse>?> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public IQueryable<ICourse> GetQueryable()
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<ICourse>> GetByArticleIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<ICourse?> GetByGuidAsync(string guid)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ICourse comment)
    {
        throw new NotImplementedException();
    }
}
