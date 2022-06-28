using Mmc.Blog.BaseType;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class Picture : IPicture
{
    public Picture(string location)
    {
        Location = location;
        Guid = new GuidType();
        Type = PictureType.ProfilePicture;
        UploadedDate = DateTime.Now;
    }

    public long Id { get; }
    public GuidType Guid { get; set; }
    public PictureType Type { get; set; }
    public string Location { get; }
    public DateTime UploadedDate { get; }
    public IBlogUser? UploadedBy { get; }
    public long? UploadedById { get; }
    public bool IsProfilePicture => Type == PictureType.ProfilePicture;
}
