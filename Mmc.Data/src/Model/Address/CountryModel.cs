using Mmc.Address.Entity.Interface;
using UserCountry = Mmc.User.Entity.Interface.ICountry;
using UserState = Mmc.User.Entity.Interface.IState;
using UserVdc = Mmc.User.Entity.Interface.IVdc;

namespace Mmc.Data.Model.Address;

public class CountryModel : ICountry, UserCountry
{
    public long Id { get; set; }
    public string Name { get; init; }
    public string? Description { get; set; }
    public string PhoneCode { get; set; }
    public string Abbreviation { get; set; }
    public virtual ICollection<StateModel> States { get; protected set; }
    ICollection<IState> ICountry.States => States.Cast<IState>().ToList();
    ICollection<UserState> UserCountry.States => States.Cast<UserState>().ToList();
}
