using Mmc.Address.Entity.Interface;

namespace Mmc.Data.Model.Address;

public class VdcModel : IVdc
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public long StateId { get; set; }
    public virtual StateModel State { get; set; }
    IState IVdc.State => State;
}