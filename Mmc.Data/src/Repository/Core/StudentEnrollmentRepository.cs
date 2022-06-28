using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Mmc.Core.Entity.Interface;
using Mmc.Core.Exception;
using Mmc.Core.Repository;
using Mmc.Data.Model.Core;
using Mmc.Data.Model.User;

namespace Mmc.Data.Repository.Core;

public class StudentEnrollmentRepository : BaseRepository<StudentEnrollmentModel>,IStudentEnrollmentRepository
{
    public async Task<IStudentEnrollment?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id);
    }

    public async Task<IStudentEnrollment> InsertAsync(IStudentEnrollment entity)
    {
        var model = new StudentEnrollmentModel(entity.Guid,entity.Semester,(UserModel)entity.User,(CourseModel)entity.Course,entity.Status);
        await base.InsertAsync(model);
        return model;
    }

    public async Task<ICollection<IStudentEnrollment>?> GetAllAsync()
    {
        return (await base.GetAllAsync()).Cast<IStudentEnrollment>().ToList();
    }

    public IQueryable<IStudentEnrollment> GetQueryable()
    {
        return base.GetQueryable();
    }

    public async Task<IStudentEnrollment?> GetByGuidAsync(string guid)
    {
        return await GetQueryable().SingleOrDefaultAsync(x => x.Guid == guid) ?? throw new StudentEnrollmentNotFoundException();
    }

    public Task UpdateAsync(IStudentEnrollment enrollment)
    {
        return base.UpdateAsync((StudentEnrollmentModel)enrollment);
    }

    public async Task<ICollection<IStudentEnrollment>> FindBy(Expression<Func<IStudentEnrollment, bool>> expression)
    {
        return await GetQueryable().Where(expression).ToListAsync();
    }

    public StudentEnrollmentRepository(AppDbContext context) : base(context)
    {
    }
}
