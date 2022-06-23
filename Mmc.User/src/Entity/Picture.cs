using Mmc.User.BaseType;
using Mmc.User.Entity.Interface;
using Mmc.User.Enum;

namespace Mmc.User.Entity;

public class Picture : IPicture
{
    public long Id { get; }
    public GuidType Guid { get; set; }
    public PictureType Type { get; }
    public string Location { get; }
    public DateTime UploadedDate { get; }
}
