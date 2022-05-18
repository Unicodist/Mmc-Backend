namespace Mmc.User.Enum;

public class UserType : BaseEnum
{
    public static UserType User = new UserType(1, _user);
    private static string _user = "User";

    private UserType(int i, string? value): base(i, value)
    {
    }
}