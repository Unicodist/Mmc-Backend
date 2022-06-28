using Mmc.Blog.Entity.Interface;
using Mmc.Data.Model.User;
using Mmc.User.Entity.Interface;
using UserPictureType = Mmc.User.Enum.PictureType;
using BlogPictureType = Mmc.Blog.Enum.PictureType;

using BlogGuidType = Mmc.Blog.BaseType.GuidType;
using UserGuidType = Mmc.User.BaseType.GuidType;

using BlogPicture = Mmc.Blog.Entity.Interface.IPicture;
using UserPicture = Mmc.User.Entity.Interface.IPicture;


namespace Mmc.Data.Model;

public class PictureModel : UserPicture, BlogPicture
{
    public PictureModel(string guid, string type, string location)
    {
        Guid = guid;
        Type = type;
        Location = location;
    }
    public PictureModel( string guid, string type, string location,DateTime uploadedDate)
    {
        Guid = guid;
        Type = type;
        Location = location;
        UploadedDate = uploadedDate;
    }

    public long Id { get; init; }
    public string Guid { get; set; }
    UserGuidType UserPicture.Guid => new(Guid);
    BlogGuidType BlogPicture.Guid => new(Type);
    public string Type { get; set; }
    UserPictureType UserPicture.Type => Type;
    BlogPictureType BlogPicture.Type => Type;
    public string Location { get; }
    public DateTime UploadedDate { get; }
}
