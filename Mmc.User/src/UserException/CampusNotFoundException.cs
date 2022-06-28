namespace Mmc.User.UserException;

public class CampusNotFoundException : Exception
{
    public CampusNotFoundException() : base("Cannot find such campus")
    {
    }

    public CampusNotFoundException(string? message) : base(message)
    {
    }
}
