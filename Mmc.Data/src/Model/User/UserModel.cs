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
    public UserModel(string name, string userType, string email, string password, string userName, OrganizationModel organization)
    {
        Name = name;
        UserType = userType;
        Email = email;
        Password = password;
        UserName = userName;
        Organization = organization;
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
    public virtual OrganizationModel Organization { get; set; }
    IOrganization IUser.Organization => Organization;
    public long OrganizationId
    {
        get;
        set;
    }

    public long? PictureId { get; set; }
    public virtual PictureModel Picture { get; set; }
    Mmc.User.Entity.Interface.IPicture IUser.Picture => Picture;
    IPicture IBlogUser.Picture => Picture;

    public void MakeAdmin()
    {
        UserType = Mmc.User.Enum.UserType.ADMIN;
    }

    public void MakeUser()
    {
        UserType = Mmc.User.Enum.UserType.USER;
    }

    public void Update(string dtoName, string dtoEmail, Mmc.User.Entity.Interface.IPicture picture, string dtoPassword,
        string dtoUsername, IOrganization organization)
    {
        Name = dtoName;
        Email = dtoEmail;
        Picture = (PictureModel)picture;
    }
}
