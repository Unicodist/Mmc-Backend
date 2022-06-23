namespace Mmc.Core.Enums;

public class UserType : BaseEnum
{
    private const string _superAdmin = "SuperAdmin";
    private const string _admin = "Admin";
    private const string _mod = "Mod";
    private const string _user = "User";

    public static UserType SuperAdmin { get; set; } = new(1,_superAdmin);
    public static UserType Admin { get; set; } = new(2,_admin);
    public static UserType Mod { get; set; } = new(3,_mod);
    public static UserType User { get; set; } = new(4, _user);

    public UserType(int id, string name) : base(id, name)
    {
        
    }
}