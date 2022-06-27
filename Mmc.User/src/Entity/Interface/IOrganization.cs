namespace Mmc.User.Entity.Interface;

public interface IOrganization
{
    long Id { get; }
    public string Name { get; }
    public string Subtitle { get; }
    public IState State { get; }
    public ICountry Country { get; }
    public IVdc Vdc { get; }
    public int Ward { get; }
}
