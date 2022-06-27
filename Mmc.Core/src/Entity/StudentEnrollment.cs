using Mmc.Core.BaseType;
using Mmc.Core.Entity.Interface;
using Mmc.Core.Enum;
using Mmc.User.Entity.Interface;

namespace Mmc.Core.Entity;

public class StudentEnrollment : IStudentEnrollment
{
    public StudentEnrollment( IUser user,ICourse course,Semester semester)
    {
        Semester = semester;
        User = user;
        Course = course;
        Status = StudentEnrollmentStatus.Active;
    }

    public long Id { get; }
    public GuidType Guid { get; }
    public long CourseId { get; }
    public Semester Semester { get; set; }
    public long UserId { get; }
    public StudentEnrollmentStatus Status { get; }
    public IUser User { get; }
    public ICourse Course { get; set; }

    public void Update(Semester dtoSemester, ICourse course)
    {
        Course = course;
        Semester = dtoSemester;
    }
}
