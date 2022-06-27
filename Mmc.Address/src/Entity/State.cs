using Mmc.Address.Entity.Interface;
using Mmc.Data.Model.Address;

namespace Mmc.Address.Entity;

public class State : IState
{
    public long Id { get; set; }
    public string Name { get; set; }
    public long CountryId { get; set; }
    public string Description { get; set; }
    public virtual Country Country { get; }
    ICountry IState.Country => Country;
    public virtual ICollection<Vdc> Vdcs { get; }
    ICollection<IVdc> IState.Vdcs => Vdcs.Cast<IVdc>().ToList();
}
