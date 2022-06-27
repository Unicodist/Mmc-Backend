using Mmc.Address.Entity.Interface;

namespace Mmc.Address.Entity;

public class Country : ICountry
{
    public long Id { get; set; }
    public string Name { get; }
    public string? Description { get; }
    public string PhoneCode { get; }
    public string Abbreviation { get; }
    public virtual ICollection<State> States { get; set; }
    ICollection<IState> ICountry.States => States.Cast<IState>().ToList();
}
