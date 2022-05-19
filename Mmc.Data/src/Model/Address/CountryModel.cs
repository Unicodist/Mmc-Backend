using Mmc.Address.Entity.Interface;

namespace Mmc.Data.Model.Address;

public class CountryModel : ICountry
{
    public ICollection<StateModel> States { get; set; }
}