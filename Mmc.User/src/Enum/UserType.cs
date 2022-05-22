namespace Mmc.User.Enum;

public class UserType : BaseEnum
{
    public static UserType User = new UserType(1, _user);
    public static UserType Superuser = new UserType(2, _superuser);
    private static string _user = "User";
    private static string _superuser = "Superuser";

    private UserType(int id, string value): base(id, value)
    {
        
    }
    public static implicit operator string(UserType value)=>value.ToString();
    public static implicit operator UserType(string value)=>GetAll<UserType>().SingleOrDefault(x => x.ToString() == value);
}