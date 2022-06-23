namespace Mmc.User.Enum;

public class PictureType : BaseEnum
{
    private const string _avatar = "Avatar";
    private const string _profilePicture = "Profile";

    public static PictureType Avatar { get; set; } = new(1,_avatar);
    public static PictureType ProfilePicture { get; set; } = new(2,_profilePicture);

    public PictureType(int id, string name) : base(id, name)
    {
        
    }
    public static implicit operator PictureType(string type)
    {
        return GetAll<PictureType>().SingleOrDefault(x => x.Value == type)!;
    }
    
}
