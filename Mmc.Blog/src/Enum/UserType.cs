namespace Mmc.Blog.Enum;

public class UserType : BaseEnum
{
    public static readonly UserType USER = new(1, User);
    public static readonly UserType SUPERUSER = new(2, Superuser);
    public static readonly UserType ADMIN = new(3, Admin);
    private const string User = "User";
    private const string Superuser = "Superuser";
    private const string Admin = "Admin";

    private UserType(int id, string value): base(id, value)
    {
        
    }
    public static implicit operator string(UserType value)=>value.ToString();
    public static implicit operator UserType(string value)=>GetAll<UserType>().SingleOrDefault(x => x.ToString() == value)??USER;
}
