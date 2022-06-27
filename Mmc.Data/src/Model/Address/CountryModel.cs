using Mmc.Address.Entity;
using Mmc.Address.Entity.Interface;
using UserCountry = Mmc.User.Entity.Interface.ICountry;
using UserState = Mmc.User.Entity.Interface.IState;
using UserVdc = Mmc.User.Entity.Interface.IVdc;

namespace Mmc.Data.Model.Address;

public class CountryModel : ICountry, UserCountry
{
    public long Id { get; set; }
    public string Name { get; }
    public string? Description { get; }
    public string PhoneCode { get; }
    public string Abbreviation { get; }
    public virtual ICollection<StateModel> States { get; set; }
    ICollection<IState> ICountry.States => States.Cast<IState>().ToList();
    ICollection<UserState> UserCountry.States => States.Cast<UserState>().ToList();
}
