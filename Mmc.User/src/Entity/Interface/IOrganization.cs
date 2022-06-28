using Mmc.User.BaseType;

namespace Mmc.User.Entity.Interface;

public interface IOrganization
{
    GuidType Guid { get; }
    long Id { get; }
    public string Name { get; }
    public string Subtitle { get; }
    public IVdc Vdc { get; }
    public int Ward { get; }
}
