namespace Mmc.Address.Entity.Interface;

public interface IState
{
    long Id { get; }
    string Name { get; }
    long CountryId { get; }
    string Description { get; }
    ICountry Country { get; }
}