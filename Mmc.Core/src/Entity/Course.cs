using Mmc.Core.BaseType;
using Mmc.Core.Entity.Interface;
using Mmc.Core.Enums;

namespace Mmc.Core.Entity;

public class Course : ICourse
{
    public Course(string name, IFaculty faculty)
    {
        Name = name;
        Faculty = faculty;
        Guid = new GuidType();
        Status = Status.Active;
    }

    public long Id { get; }
    public GuidType Guid { get; }
    public string Name { get; }
    public long FacultyId { get; protected set; }
    public IFaculty Faculty { get; }
    public Status Status { get; set; }
}
