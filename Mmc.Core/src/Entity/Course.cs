using Mmc.Core.BaseType;
using Mmc.Core.Entity.Interface;

namespace Mmc.Core.Entity;

public class Course : ICourse
{
    public long Id { get; }
    public GuidType Guid { get; }
    public string Name { get; }
    public IFaculty Faculty { get; }
}
