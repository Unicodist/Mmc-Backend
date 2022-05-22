namespace Mmc.User.UserException;

public class WrongPasswordException : Exception
{
    public WrongPasswordException():base("The provided password do not match"){}
}