using Mmc.Notice.BaseType;

namespace Mmc.Notice.Entity.Interface;

public interface IFaculty
{
    long Id { get; }
    GuidType Guid { get; }
    string Name { get; }
    ICollection<ICourse> Courses { get; }
}
