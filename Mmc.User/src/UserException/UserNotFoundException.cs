namespace Mmc.User.UserException;

public class UserNotFoundException : Exception
{
    public UserNotFoundException() : base("The user is not registered"){}
}