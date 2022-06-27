using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Mmc.Core.BaseType;
using Mmc.Core.Entity.Interface;
using Mmc.Core.Repository;
using Mmc.Data.Model.Core;

namespace Mmc.Data.Repository.Core;

public class CourseRepository : BaseRepository<CourseModel>, ICourseRepository
{
    public CourseRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<ICourse?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id).ConfigureAwait(false);
    }

    public async Task<ICourse> InsertAsync(ICourse entity)
    {
        var cModel = new CourseModel(entity.Name, entity.Guid, entity.Status, (FacultyModel)entity.Faculty);
        await base.InsertAsync(cModel);
        return cModel;
    }

    public new async Task<ICollection<ICourse>?> GetAllAsync()
    {
        return (await base.GetAllAsync()).Cast<ICourse>().ToList();
    }

    public new IQueryable<ICourse> GetQueryable()
    {
        return base.GetQueryable();
    }
    public async Task<ICourse?> GetByGuidAsync(string guid)
    {
        return await base.GetQueryable().SingleOrDefaultAsync(x => x.Guid == guid);
    }

    public Task UpdateAsync(ICourse course)
    {
        return base.Update((CourseModel)course);
    }

    public async Task<ICollection<ICourse>> FindBy(Expression<Func<ICourse,bool>> predicate)
    {
        return await GetQueryable().Where(predicate).ToListAsync();
    }
}
