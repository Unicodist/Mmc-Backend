using Mmc.Core.BaseType;
using Mmc.Core.Enum;

namespace Mmc.Core.Entity.Interface;

public interface ICourse
{
    long Id { get; }
    GuidType Guid { get; }
    string Name { get; }
    public long FacultyId { get; }
    
    IFaculty Faculty { get; }
    Status Status { get; }
}
