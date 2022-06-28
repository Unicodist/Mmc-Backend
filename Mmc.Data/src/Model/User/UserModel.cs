using Mmc.Blog.Entity.Interface;
using Mmc.Data.Model.Core;
using Mmc.Notice.Entity.Interface;
using Mmc.User.Entity.Interface;
using Mmc.User.Enum;
using IPicture = Mmc.Blog.Entity.Interface.IPicture;

namespace Mmc.Data.Model.User;
public class UserModel: IUser,
    IBlogUser,
    INoticeUser
{
    public UserModel(string name, string userType, string email, string password, string userName,
        PictureModel pictureModel)
    {
        Name = name;
        UserType = userType;
        Email = email;
        Password = password;
        UserName = userName;
        Pictures.Add(pictureModel);
    }

    public UserModel()
    {
        
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public string UserType { get; set; }
    UserType IUser.UserType => UserType;
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public virtual ICollection<PictureModel> Pictures { get; set; }
    public string GetProfilePicturePath()=> Pictures.SingleOrDefault(x => x.IsProfilePicture).Location;

    ICollection<IPicture>? IBlogUser.Pictures => Pictures.Cast<IPicture>().ToList();
    ICollection<Mmc.User.Entity.Interface.IPicture> IUser.Pictures => Pictures.Cast<Mmc.User.Entity.Interface.IPicture>().ToList();
    public virtual OrganizationModel Organization { get; set; }
    IOrganization IUser.Organization => Organization;
    public long OrganizationId
    {
        get;
        set;
    }

    public void MakeAdmin()
    {
        UserType = Mmc.User.Enum.UserType.ADMIN;
    }

    public void MakeUser()
    {
        UserType = Mmc.User.Enum.UserType.USER;
    }
}
