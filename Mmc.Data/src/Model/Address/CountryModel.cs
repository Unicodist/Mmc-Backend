using Mmc.Address.Entity.Interface;

namespace Mmc.Data.Model.Address;

public class CountryModel : ICountry
{
    public long Id { get; set; }
    public string Name { get; }
    public string? Description { get; }
    public string PhoneCode { get; }
    public string Abr { get; }
    public ICollection<StateModel> States { get; set; }
    ICollection<IState> ICountry.States => States.Cast<IState>().ToList();
}