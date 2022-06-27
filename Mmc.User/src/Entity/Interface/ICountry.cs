namespace Mmc.User.Entity.Interface;

public interface ICountry
{
    long Id { get; }
    string Name { get; }
    string? Description { get; }
    string PhoneCode { get; }
    string Abbreviation { get; }
    public ICollection<IState> States { get; }
}
