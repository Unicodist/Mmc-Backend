using Mmc.User.BaseType;
using Mmc.User.Enum;

namespace Mmc.User.Entity.Interface;

public interface IPicture
{
    public long Id { get; }
    public GuidType Guid { get; }
    public PictureType Type { get; }
    public string Location { get; }
    public DateTime UploadedDate { get; }
}
