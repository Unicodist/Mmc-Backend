using Mmc.Address.Entity.Interface;

namespace Mmc.Data.Model.Address;

public class StateModel : IState
{
    public long Id { get; set; }
    public string Name { get; set; }
    public long CountryId { get; set; }
    public string Description { get; set; }
    public virtual CountryModel Country { get; }
    ICountry IState.Country => Country;
    public virtual ICollection<VdcModel> Vdcs { get; }
    ICollection<IVdc> IState.Vdcs => Vdcs.Cast<IVdc>().ToList();
}