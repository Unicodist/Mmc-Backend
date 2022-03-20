namespace Mmc.Core.Enum;

public class UserType : BaseEnum
{
    private const string Sadmin = "SuperAdmin";
    private const string Admin = "Admin";
    private const string Mod = "Mod";
    private const string User = "User";

    public static UserType SUPERADMIN { get; set; } = new UserType(1,Sadmin);
    public static UserType ADMIN { get; set; } = new UserType(2,Admin);
    public static UserType MOD { get; set; } = new UserType(3,Mod);
    public static UserType USER { get; set; } = new UserType(4, User);

    public UserType(int id, string name) : base(id, name)
    {
        
    }
}