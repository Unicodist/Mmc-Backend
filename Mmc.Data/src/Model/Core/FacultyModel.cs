using CoreFaculty = Mmc.Core.Entity.Interface.IFaculty;
using NoticeFaculty = Mmc.Notice.Entity.Interface.IFaculty;
using CoreCourse = Mmc.Core.Entity.Interface.ICourse;
using NoticeCourse = Mmc.Notice.Entity.Interface.ICourse;
using CoreGuid = Mmc.Core.BaseType.GuidType;
using NoticeGuid = Mmc.Notice.BaseType.GuidType;

namespace Mmc.Data.Model.Core;

public class FacultyModel : CoreFaculty, NoticeFaculty
{
    public FacultyModel()
    {
    }

    public long Id { get; }
    public string Guid { get; }
    CoreGuid CoreFaculty.Guid => new(Guid);
    NoticeGuid NoticeFaculty.Guid => new(Guid);
    
    public string Name { get; }
    public virtual ICollection<CourseModel> Courses { get; }
    ICollection<CoreCourse> CoreFaculty.Courses => Courses.Cast<CoreCourse>().ToList();
    ICollection<NoticeCourse> NoticeFaculty.Courses => Courses.Cast<NoticeCourse>().ToList();
}
