using Mmc.Address.Entity.Interface;
using UserCountry = Mmc.User.Entity.Interface.ICountry;
using UserState = Mmc.User.Entity.Interface.IState;
using UserVdc = Mmc.User.Entity.Interface.IVdc;

namespace Mmc.Data.Model.Address;

public class StateModel : IState, UserState
{
    public StateModel(string name, string description, CountryModel country)
    {
        Name = name;
        Description = description;
        Country = country;
    }

    public StateModel()
    {
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public long CountryId { get; set; }
    public string Description { get; set; }
    public virtual CountryModel Country { get; }
    ICountry IState.Country => Country;
    UserCountry UserState.Country => Country;
    public virtual ICollection<VdcModel> Vdcs { get; }
    ICollection<IVdc> IState.Vdcs => Vdcs.Cast<IVdc>().ToList();
    ICollection<UserVdc> UserState.Vdcs => Vdcs.Cast<UserVdc>().ToList();
}
