using Mmc.Core.BaseType;

namespace Mmc.Core.Entity.Interface;

public interface ICourse
{
    long Id { get; }
    GuidType Guid { get; }
    string Name { get; }
    
    IFaculty Faculty { get; }
}
