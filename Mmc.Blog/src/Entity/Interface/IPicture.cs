using Mmc.Blog.BaseType;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity.Interface;

public interface IPicture
{
    public long Id { get; }
    public GuidType Guid { get; }
    public PictureType Type { get; }
    public string Location { get; }
    public DateTime UploadedDate { get; }
    IBlogUser UploadedBy { get; }
    long UploadedById { get; }
    bool IsProfilePicture { get; }
}
