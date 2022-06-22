namespace Mmc.Blog.Exception;

public class UserNotFoundException : System.Exception
{
    public UserNotFoundException() : base("The user is not registered"){}
}