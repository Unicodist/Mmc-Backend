using Mmc.Notice.BaseType;

namespace Mmc.Notice.Entity.Interface;

public interface ICourse
{
    long Id { get; }
    GuidType Guid { get; }
    string Name { get; }
    
    IFaculty Faculty { get; }
}
