using Mmc.User.BaseType;
using Mmc.User.Entity.Interface;
using Mmc.User.Enum;

namespace Mmc.User.Entity;

public class Picture : IPicture
{
    public Picture()
    {
    }

    public Picture(string location)
    {
        Location = location;
        Type = PictureType.ProfilePicture;
        UploadedDate = DateTime.Now;
    }

    public long Id { get; }
    public GuidType Guid { get; set; }
    public PictureType Type { get; }
    public string Location { get; }
    public DateTime UploadedDate { get; }
    public IUser UploadedBy { get; set; }
    public long UploadedById { get; set; }
    public void MarkProfilePicture()
    {
        throw new NotImplementedException();
    }
}
