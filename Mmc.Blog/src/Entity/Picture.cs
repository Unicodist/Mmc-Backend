using Mmc.Blog.BaseType;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class Picture : IPicture
{
    public long Id { get; }
    public GuidType Guid { get; set; }
    public PictureType Type { get; }
    public string Location { get; }
    public DateTime UploadedDate { get; }
}
