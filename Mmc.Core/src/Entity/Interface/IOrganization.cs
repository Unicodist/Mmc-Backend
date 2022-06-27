using Mmc.Address.Entity;
using Mmc.Data.Model.Address;

namespace Mmc.Core.Entity.Interface;

public interface IOrganization
{
    long Id { get; }
    public string Name { get; set; }
    public string Subtitle { get; set; }
    public State State { get; set; }
    public Country Country { get; set; }
    public Vdc Vdc { get; set; }
    public int Ward { get; set; }
}
