using Mmc.Notice.BaseType;

namespace Mmc.Notice.Entity.Interface;

public interface ICourse
{
    long Id { get; }
    GuidType Guid { get; }
    string Name { get; }
    public long FacultyId { get; }
    
    IFaculty Faculty { get; }
}
