using System.Linq.Expressions;
using Mmc.Core.Entity.Interface;

namespace Mmc.Core.Repository;

public interface IStudentEnrollmentRepository
{
    Task<IStudentEnrollment?> GetByIdAsync(long id);
    Task<IStudentEnrollment> InsertAsync(IStudentEnrollment entity);
    Task<ICollection<IStudentEnrollment>?> GetAllAsync();
    IQueryable<IStudentEnrollment> GetQueryable();
    Task<IStudentEnrollment?> GetByGuidAsync(string guid);
    Task UpdateAsync(IStudentEnrollment enrollment);
    Task<ICollection<IStudentEnrollment>> FindBy(Expression<Func<IStudentEnrollment,bool>> expression);
}
