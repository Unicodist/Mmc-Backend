using Mmc.Core.BaseType;
using Mmc.Core.Enum;
using Mmc.User.Entity.Interface;

namespace Mmc.Core.Entity.Interface;

public interface IStudentEnrollment
{
    long Id { get; }
    GuidType Guid { get; }
    long CourseId { get; }
    Semester Semester { get; }
    long UserId { get; }
    StudentEnrollmentStatus Status { get; }
    
    IUser User { get; }
    ICourse Course { get; }
    void Update(Semester dtoSemester, ICourse course);
}
