using CoreCourse = Mmc.Core.Entity.Interface.ICourse;
using NoticeCourse = Mmc.Notice.Entity.Interface.ICourse;
using CoreFaculty = Mmc.Core.Entity.Interface.IFaculty;
using NoticeFaculty = Mmc.Notice.Entity.Interface.IFaculty;
using CoreGuid = Mmc.Core.BaseType.GuidType;
using NoticeGuid = Mmc.Notice.BaseType.GuidType;

namespace Mmc.Data.Model.Core;

public class CourseModel : CoreCourse, NoticeCourse
{
    public long Id { get; }
    public string Guid { get; }
    CoreGuid CoreCourse.Guid => new(Guid);
    NoticeGuid NoticeCourse.Guid => new(Guid);
    
    public string Name { get; }
    public virtual FacultyModel Faculty { get; set; }
    CoreFaculty CoreCourse.Faculty => Faculty;
    NoticeFaculty NoticeCourse.Faculty => Faculty;
}
