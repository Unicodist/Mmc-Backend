using Mmc.Core.BaseType;
using Mmc.Core.Entity.Interface;
using Mmc.Core.Enum;
using Mmc.Data.Model.User;
using Mmc.User.Entity.Interface;

namespace Mmc.Data.Model.Core;

public class StudentEnrollmentModel : IStudentEnrollment
{
    public StudentEnrollmentModel()
    {
    }

    public StudentEnrollmentModel(GuidType guid, Semester semester, UserModel user, CourseModel course, StudentEnrollmentStatus status)
    {
        Guid = guid;
        Semester = semester;
        User = user;
        Course = course;
        Status = status;
    }

    public long Id { get; }
    public GuidType Guid { get; }
    public long CourseId { get; }
    public Semester Semester { get; set; }
    public long UserId { get; }
    public StudentEnrollmentStatus Status { get; set; }
    public virtual UserModel User { get; set; }
    IUser IStudentEnrollment.User => User;
    public virtual CourseModel Course { get; set; }
    public void Update(Semester dtoSemester, ICourse course)
    {
        Semester = dtoSemester;
        Course = (CourseModel) course;
    }

    ICourse IStudentEnrollment.Course => Course;
}
