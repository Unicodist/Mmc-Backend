namespace Mmc.Address.Entity.Interface;

public interface ICountry
{
    long Id { get; }
    string Name { get; }
    string? Description { get; }
    string PhoneCode { get; }
    string Abr { get; }
    public ICollection<IState> States { get; }
}