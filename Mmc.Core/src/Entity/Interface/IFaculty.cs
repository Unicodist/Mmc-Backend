using Mmc.Core.BaseType;

namespace Mmc.Core.Entity.Interface;

public interface IFaculty
{
    long Id { get; }
    GuidType Guid { get; }
    string Name { get; }
    ICollection<ICourse> Courses { get; }
}
