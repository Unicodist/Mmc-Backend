namespace Mmc.User.Entity.Interface;

public interface IVdc
{
    long Id { get; }
    string Name { get; }
    string? Description { get; }
    long StateId { get; }
    IState State { get; }
}
