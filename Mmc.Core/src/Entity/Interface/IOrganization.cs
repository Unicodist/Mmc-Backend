using Mmc.Address.Entity.Interface;

namespace Mmc.Core.Entity.Interface;

public interface IOrganization
{
    long Id { get; }
    string Name { get; }
    string Subtitle { get; }
    long VdcId { get; }
    IVdc Vdc { get; }
    int Ward { get; }
}
