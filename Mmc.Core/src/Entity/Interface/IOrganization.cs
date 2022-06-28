using Mmc.Address.Entity.Interface;
using Mmc.Core.BaseType;

namespace Mmc.Core.Entity.Interface;

public interface IOrganization
{
    GuidType Guid { get; }
    long Id { get; }
    string Name { get; }
    string Subtitle { get; }
    long VdcId { get; }
    IVdc Vdc { get; }
    int Ward { get; }
}
